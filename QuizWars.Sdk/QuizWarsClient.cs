﻿using QuizWars.Sdk.Services;

namespace QuizWars.Sdk;

public class QuizWarsClient(HttpClient client)
{
    public GameService Games => new(client);
    
    public TopicService Topics => new(client);
    
    public UserService Users => new(client);
}