﻿namespace PerfDataService.Models
{
    public sealed class HotspotsTreeNodeViewModel : TreeNode
    {
        public string Link => "stackviewer/callers/" + this.Id;
    }
}