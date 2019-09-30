using System;

namespace Model
{
    public class Activity
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
        public DateTime endTime { get; set; }
       
    }
    public class WorkInfo
    { 
        public int workId { get; set; }
    }
    public class Comment
    {
        public int commentId { get; set; }
       
    }
    public class WorkFindPage : Page
    {
        public string workName { get;set }
    }
}
