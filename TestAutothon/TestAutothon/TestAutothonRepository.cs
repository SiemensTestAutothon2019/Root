﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TestAutothon
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TestAutothonRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b4292495-4ad5-4e0c-bdba-afa9ef290732")]
    public partial class TestAutothonRepository : RepoGenBaseFolder
    {
        static TestAutothonRepository instance = new TestAutothonRepository();
        TestAutothonRepositoryFolders.StepInForumYouTubeAppFolder _stepinforumyoutube;

        /// <summary>
        /// Gets the singleton class instance representing the TestAutothonRepository element repository.
        /// </summary>
        [RepositoryFolder("b4292495-4ad5-4e0c-bdba-afa9ef290732")]
        public static TestAutothonRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TestAutothonRepository() 
            : base("TestAutothonRepository", "/", null, 0, false, "b4292495-4ad5-4e0c-bdba-afa9ef290732", ".\\RepositoryImages\\TestAutothonRepositoryb4292495.rximgres")
        {
            _stepinforumyoutube = new TestAutothonRepositoryFolders.StepInForumYouTubeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b4292495-4ad5-4e0c-bdba-afa9ef290732")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The StepInForumYouTube folder.
        /// </summary>
        [RepositoryFolder("bbb80d28-40ed-429b-963d-836de6934076")]
        public virtual TestAutothonRepositoryFolders.StepInForumYouTubeAppFolder StepInForumYouTube
        {
            get { return _stepinforumyoutube; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class TestAutothonRepositoryFolders
    {
        /// <summary>
        /// The StepInForumYouTubeAppFolder folder.
        /// </summary>
        [RepositoryFolder("bbb80d28-40ed-429b-963d-836de6934076")]
        public partial class StepInForumYouTubeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _searchqueryInfo;
            RepoItemInfo _searchbuttonInfo;
            RepoItemInfo _stepinforumInfo;
            RepoItemInfo _videostabInfo;
            RepoItemInfo _stepinvideosallInfo;
            RepoItemInfo _stepinvideoInfo;

            /// <summary>
            /// Creates a new StepInForumYouTube  folder.
            /// </summary>
            public StepInForumYouTubeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("StepInForumYouTube", "/dom[@domain='www.youtube.com']", parentFolder, 30000, null, false, "bbb80d28-40ed-429b-963d-836de6934076", "")
            {
                _searchqueryInfo = new RepoItemInfo(this, "SearchQuery", ".//div[#'search-input']/input[@id='search']", 30000, null, "9310d706-cbf3-49f2-a160-4ca480edbeb7");
                _searchbuttonInfo = new RepoItemInfo(this, "SearchButton", ".//button[#'search-icon-legacy']/tag[@tagname='yt-icon']", 30000, null, "67650128-7891-4e39-b1c8-15c0adaae44d");
                _stepinforumInfo = new RepoItemInfo(this, "STePINForum", ".//tag[#'page-manager']//span[@innertext='STeP-IN Forum']", 30000, null, "ae9602e0-c7ee-43e9-9c29-d24369128682");
                _videostabInfo = new RepoItemInfo(this, "VideosTab", ".//div[#'tabsContent']/?/?/div[@innertext>'                    Videos']", 30000, null, "c600e24a-120e-4083-82ab-f84a9dd79a1c");
                _stepinvideosallInfo = new RepoItemInfo(this, "StepInVideosAll", ".//tag[#'page-manager']/tag[4]/tag[@tagname='ytd-two-column-browse-results-renderer']/div[@id='primary']/?/?/div[@id='contents']/?/?/div[@id='contents']", 30000, null, "31193da7-ea40-4b82-b6f0-1a7a84250ae6");
                _stepinvideoInfo = new RepoItemInfo(this, "StepInVideo", ".//tag[#'page-manager']/tag[4]/tag[@tagname='ytd-two-column-browse-results-renderer']/div[@id='primary']/?/?/div[@id='contents']/?/?/div[@id='contents']/?/?/div[@id='items']/tag[3]/div[@id='dismissable']/div[@id='details']/div[@id='meta']/?/?/a[@id='video-title']", 30000, null, "57299b54-89af-4595-b3ae-a6b6a468b3d1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bbb80d28-40ed-429b-963d-836de6934076")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bbb80d28-40ed-429b-963d-836de6934076")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SearchQuery item.
            /// </summary>
            [RepositoryItem("9310d706-cbf3-49f2-a160-4ca480edbeb7")]
            public virtual Ranorex.InputTag SearchQuery
            {
                get
                {
                    return _searchqueryInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The SearchQuery item info.
            /// </summary>
            [RepositoryItemInfo("9310d706-cbf3-49f2-a160-4ca480edbeb7")]
            public virtual RepoItemInfo SearchQueryInfo
            {
                get
                {
                    return _searchqueryInfo;
                }
            }

            /// <summary>
            /// The SearchButton item.
            /// </summary>
            [RepositoryItem("67650128-7891-4e39-b1c8-15c0adaae44d")]
            public virtual Ranorex.WebElement SearchButton
            {
                get
                {
                    return _searchbuttonInfo.CreateAdapter<Ranorex.WebElement>(true);
                }
            }

            /// <summary>
            /// The SearchButton item info.
            /// </summary>
            [RepositoryItemInfo("67650128-7891-4e39-b1c8-15c0adaae44d")]
            public virtual RepoItemInfo SearchButtonInfo
            {
                get
                {
                    return _searchbuttonInfo;
                }
            }

            /// <summary>
            /// The STePINForum item.
            /// </summary>
            [RepositoryItem("ae9602e0-c7ee-43e9-9c29-d24369128682")]
            public virtual Ranorex.SpanTag STePINForum
            {
                get
                {
                    return _stepinforumInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The STePINForum item info.
            /// </summary>
            [RepositoryItemInfo("ae9602e0-c7ee-43e9-9c29-d24369128682")]
            public virtual RepoItemInfo STePINForumInfo
            {
                get
                {
                    return _stepinforumInfo;
                }
            }

            /// <summary>
            /// The VideosTab item.
            /// </summary>
            [RepositoryItem("c600e24a-120e-4083-82ab-f84a9dd79a1c")]
            public virtual Ranorex.DivTag VideosTab
            {
                get
                {
                    return _videostabInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The VideosTab item info.
            /// </summary>
            [RepositoryItemInfo("c600e24a-120e-4083-82ab-f84a9dd79a1c")]
            public virtual RepoItemInfo VideosTabInfo
            {
                get
                {
                    return _videostabInfo;
                }
            }

            /// <summary>
            /// The StepInVideosAll item.
            /// </summary>
            [RepositoryItem("31193da7-ea40-4b82-b6f0-1a7a84250ae6")]
            public virtual Ranorex.DivTag StepInVideosAll
            {
                get
                {
                    return _stepinvideosallInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The StepInVideosAll item info.
            /// </summary>
            [RepositoryItemInfo("31193da7-ea40-4b82-b6f0-1a7a84250ae6")]
            public virtual RepoItemInfo StepInVideosAllInfo
            {
                get
                {
                    return _stepinvideosallInfo;
                }
            }

            /// <summary>
            /// The StepInVideo item.
            /// </summary>
            [RepositoryItem("57299b54-89af-4595-b3ae-a6b6a468b3d1")]
            public virtual Ranorex.ATag StepInVideo
            {
                get
                {
                    return _stepinvideoInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The StepInVideo item info.
            /// </summary>
            [RepositoryItemInfo("57299b54-89af-4595-b3ae-a6b6a468b3d1")]
            public virtual RepoItemInfo StepInVideoInfo
            {
                get
                {
                    return _stepinvideoInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
