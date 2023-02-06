namespace DAL;
using BuisnessObjectLayer;
using System.Text.Json;
public static class TopicRepository
{
    public static List<Topic> GetAllTopics()
    {
        string restoredJsonString=File.ReadAllText(@"..\ExamDAL\JsonFiles\Topics.json");
        List<Topic> topics=JsonSerializer.Deserialize<List<Topic>>(restoredJsonString);
        return topics;
    }

    public static void AddTopic(Topic topic)
    {
        string restoredJsonString=File.ReadAllText(@"..\ExamDAL\JsonFiles\Topics.json");
        List<Topic> topics=JsonSerializer.Deserialize<List<Topic>>(restoredJsonString);
        topics.Add(topic);

        string jsonString=JsonSerializer.Serialize(topics);
        File.WriteAllText(@"..\ExamDAL\JsonFiles\Topics.json",jsonString);

    }
}