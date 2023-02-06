namespace BuisnessLogicLayer;
using BuisnessObjectLayer;
using System.Collections.Generic;
using DAL;

public static class TopicManager
{


    public static List<Topic> GetTopics()
    {
        return TopicRepository.GetAllTopics();
    }

    public static Topic GetTopicByID(int id)
    {
        List<Topic> topics = GetTopics();
        foreach(Topic topic in topics)
        {
            if(topic.Id == id)
            {
                return topic;
            }
        }
        return null;
    }

    public static void AddTopic(Topic newTopic)
    {
        TopicRepository.AddTopic(newTopic);
    }
}