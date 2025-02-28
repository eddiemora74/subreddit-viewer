namespace subreddit_search_blazor.webapp.Models;

public class RedditEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Reddit Reddit { get; set; }
    public string Url { get; set; }

    public static RedditEntry Create(Reddit reddit, string url)
    {
        return new RedditEntry { Reddit = reddit, Url = url };
    }
}

public class Reddit
{
    public string kind { get; set; }
    public Data data { get; set; }
}

public class Child
{
    public string kind { get; set; }
    public Data data { get; set; }
}

public class Data
{
    public string after { get; set; }
    public int dist { get; set; }
    public string modhash { get; set; }
    public object geo_filter { get; set; }
    public List<Child> children { get; set; }
    public object before { get; set; }
    public string subreddit { get; set; }
    public string subreddit_name_prefixed { get; set; }
    public string selftext { get; set; }
    public string author_fullname { get; set; }
    public string title { get; set; }
    public int downs { get; set; }
    public double upvote_ratio { get; set; }
    public string subreddit_type { get; set; }
    public int ups { get; set; }
    public int score { get; set; }
    public string permalink { get; set; }
}