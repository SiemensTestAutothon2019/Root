using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIClient
{
    public class Video
    {
        public string VideoName { get; set; }
    }

    /// <summary>
    /// Wrapper for JSON file format
    /// </summary>
    public class JSONWrapper
    {
        public string  Team { get; set; }

        public string Video { get; set; }

        public List<string> Upcomingvideos { get; set; }
    }

    class Program
    {
        static HttpClient client = new HttpClient();

        /// <summary>
        /// Fetches random Video URL from web api.
        /// </summary>
        /// <param name="path">Web API URL</param>
        /// <returns>Video class object containing video search string</returns>
        static async Task<Video> GetVideoAsync(string path)
        {
            Video video = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                video = new Video();
                video.VideoName = response.Content.ReadAsStringAsync().Result;
            }
            return video;
        }


        static async Task<bool> ValidateUpload(JSONWrapper jsonWrapperInstance, string uploadResponse)
        {
            bool ValidateStatus = true;
            string baseURL = "http://54.169.34.162:5252/result/";
            baseURL = baseURL + uploadResponse;

            HttpResponseMessage response = await client.GetAsync(baseURL);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                JSONWrapper jsonWrapperFromAPI = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONWrapper>(jsonString);

                if(jsonWrapperInstance.Team == jsonWrapperFromAPI.Team)
                {
                    if(jsonWrapperInstance.Video == jsonWrapperInstance.Video)
                    {
                        foreach(string upcomingVid in jsonWrapperInstance.Upcomingvideos)
                        {
                            if(jsonWrapperFromAPI.Upcomingvideos.Find(x=>x.Equals(upcomingVid)) == null)
                            {
                                ValidateStatus = false;
                            }
                        }
                    }
                }
            }
            return ValidateStatus;
        }


        static async Task<string> UploadFile(string filePath)
        {
            string response = string.Empty;
            try
            {
                var webClient = new WebClient();

                byte[] file = File.ReadAllBytes(filePath);
                string filename = "OutputJSON.json";
                string contentType = "multipart/form-data";
                string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
                webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
                var fileData = webClient.Encoding.GetString(file);
                var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, filename, contentType, fileData);

                var nfile = webClient.Encoding.GetBytes(package);

                byte[] resp = webClient.UploadData("http://54.169.34.162:5252/upload", "POST", nfile);
                response = Encoding.ASCII.GetString(resp);                

            }catch(Exception ex)
            {

            }
            return response;            

        }

        /// <summary>
        /// Creates a JSON file in specified format as JSONWrapper Class.
        /// </summary>
        /// <param name="teamName">Name of team</param>
        /// <param name="video">Video name from API</param>
        /// <param name="upcomingVideos">List of upcoming videos</param>
        /// <returns>True if file created, false in case of error</returns>
        static public bool CreateJSONFile(JSONWrapper jsonWrap)
        {
            bool fileStatus = true;
            try
            {
                using (StreamWriter file = File.CreateText(@"D:\TestAuthothon\OutputJSON.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, jsonWrap);
                }

            }catch(Exception ex)
            {
                fileStatus = false;
            }
            return fileStatus;
        }



        static void Main()
        {
            //RunAsync().GetAwaiter().GetResult();
            Tasks();

        }

        static async void Tasks()
        {
            List<string> listupcoming = new List<string>();
            listupcoming.Add("Test1");
            listupcoming.Add("Test2");

            JSONWrapper jsonWrap = new JSONWrapper();
            jsonWrap.Team = "Siemens-6";
            jsonWrap.Video = "RandomVideo";
            jsonWrap.Upcomingvideos = listupcoming;

            CreateJSONFile(jsonWrap);
            var response = await UploadFile(@"D:\TestAuthothon\OutputJSON.json");
            await ValidateUpload(jsonWrap, response);
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://54.169.34.162:5252/video");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

            try
            {
                // Create a new video instance.
                Video video = new Video();

                // Get the Video
                video = await GetVideoAsync("http://54.169.34.162:5252/video");

                if(string.IsNullOrEmpty(video.VideoName))
                {
                    Console.WriteLine("No video found");
                }
                else
                {
                    Console.WriteLine("Random Video name : " + video.VideoName);
                }

                //UploadFile();

                
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }



    }
}