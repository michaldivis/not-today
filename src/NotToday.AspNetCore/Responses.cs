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
        "Oh goodie! It seems like there's no response coming. It's just one of those days I guess.",
        "Looks like this API is on vacation - no response today!",
        "This API took a coffee break and forgot to set its out-of-office message.",
        "The API is channeling its inner introvert today - no response.",
        "This API is playing hide and seek. You found the 'hide' part.",
        "No response from the API; it must be practicing the art of silence.",
        "The API is on a digital sabbatical. No messages allowed.",
        "Sorry, the API is currently in stealth mode - no response detected.",
        "The API is embracing its inner mime. No words, just silence.",
        "This API is playing hard to get - no response in sight.",
        "The API has gone incognito - no response for now.",
        "Well, it seems this API has gone on a digital vacation. No response, just relaxation!",
        "Looks like the API decided to take a break and left us hanging. No response, no worries!",
        "This API is on strike - no response until further notice. Solidarity, comrades!",
        "In the land of APIs, this one chose the path of silence. No response, just peace and quiet.",
        "Seems like the API is practicing social distancing - no response, keeping its space.",
        "This API is channeling its inner monk - silence is its mantra. No response, just meditation.",
        "Well, well, well... no response from the API. Looks like it's gone fishing!",
        "The API seems to have taken a vow of silence. No response, just spiritual contemplation.",
        "Looks like the API is playing hide and seek with us. No response, just a game of digital peekaboo!",
        "This API is like a mime in a digital circus - no response, just silent performance art.",
    };
}
