namespace NotToday.AspNetCore;
internal static class Responses
{
    public static string GetRandomMessage()
    {
        return _messages[Random.Shared.Next(_messages.Length)];
    }

    private static readonly string[] _messages =
    {
        "Hey there, mate! Just a heads up, this API is as quiet as a library full of snoring puppies. But hey, no response means no problems, right? Peace and tranquility!",
        "Welcome to the silent realm of this API, where the absence of response is like a gentle breeze in a meadow. It's so peaceful, you can almost hear the sound of happiness.",
        "Behold, fellow traveler! This API is like a ninja in stealth mode, gracefully avoiding responses. It's so sneaky, you might start wondering if it's even there. But hey, embrace the tranquility!",
        "Greetings, noble soul! Here, in the realm of this API, responses are as elusive as a unicorn riding a rainbow. But worry not, for in the silence lies the secret of true serenity!",
        "Ah, my friend! This API is a master of the art of silence. It's like meditating in a cave of solitude, where no response is the ultimate path to enlightenment. Embrace the zen!",
        "Hear ye, hear ye! In this magical realm of the API, responses are rarer than a four-leaf clover in a field of daisies. It's like a treasure hunt where the real treasure is the absence of noise!",
        "Welcome to the land of the mute API, where silence reigns supreme. It's like a symphony of tranquility, where the lack of response is the most harmonious melody you'll ever encounter.",
        "Greetings, mortal! In the domain of this API, responses are as scarce as a sunny day in Asgard. But fear not, for in this silence lies the secret to true happiness. Enjoy the serenity!",
    };
}
