using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExamMVC.Models;
using BuisnessObjectLayer;
using BuisnessLogicLayer;

namespace ExamMVC.Controllers;

public class TopicsController : Controller
{
    private readonly ILogger<TopicsController> _logger;

    public TopicsController(ILogger<TopicsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Topic> topics = TopicManager.GetTopics();
        ViewData["topics"]=topics;
        return View();
    }

    public IActionResult GetTopic(int id)
    {
        Topic topic = TopicManager.GetTopicByID(id);
        ViewData["topic"]=topic;
        return View();
    } 

    public IActionResult Add(int id, string name, string desc, string faculty, string location)
    {
        Topic newTopic = new Topic {Id = id, Name = name, Description=desc, Faculty=faculty, Location=location};
        TopicManager.AddTopic(newTopic);
        Response.Redirect("/Topics/index");
        return View();
    } 
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
