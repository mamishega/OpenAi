// Create a new instance of the OpenAIAPI class using your API key
var api = new OpenAI_API.OpenAIAPI("Enter API Key");

// Set the maximum token count for completion requests to 1000
api.Completions.DefaultCompletionRequestArgs.MaxTokens=1000;

// Set the temperature to control the randomness of the generated output
api.Completions.DefaultCompletionRequestArgs.Temperature = 0.1;

// Send a completion request to the OpenAI API using the GetCompletion method
//var result = await api.Completions.GetCompletion("Create a  multiple choice question about Australia, 4 options, correct answer. json format.  Fields, 'question_id', 'options', 'correct'.  options have 'answer_id' and 'answertext' start num at 0");

var result = await api.Completions.GetCompletion("Generate 3 about Australia multiple-choice quiz questions with correct answers. Format the quiz in valid JSON format. Use the following JSON format but replace single quotes with double quotes: {'Question 1':{'Question':'Sample question?','Options':{'A':'Sample answer 1','B':'Sample answer 2','C':'Sample answer 3','D':'Sample answer 4'},'Answer':'B'}}");
// Print the result of the completion request to the console
Console.WriteLine(result);





