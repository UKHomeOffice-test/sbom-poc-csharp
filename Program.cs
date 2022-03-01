// Use Newtonsoft library to outout to my SBOM

var test = @"
    {
        'Hello':'World!'
    }
";

var jsonTest = Newtonsoft.Json.Linq.JObject.Parse(test);

Console.WriteLine(test);
