using System;
using System.Threading;

public class Video{
	public string Title{get; set;}
}

public class VideoEncoder{
	public delegate void VideoEncodedEventHandler(object source, EventArgs args);

	public event VideoEncodedEventHandler VideoEncoded;

	public void Encode(Video video){
		Console.WriteLine("Encoding Video.....");
		Thread.Sleep(3000);

		OnVideoEncoded();
	}

	protected virtual void OnVideoEncoded(){
		if(VideoEncoded != null){
			VideoEncoded(this, EventArgs.Empty);
		}
	}
}

public class MailService{
	public void OnVideoEncoded(object source, EventArgs args){
		Console.WriteLine("MailService: sending an email....");
	}
}

public class MessageService{
	public void OnVideoEncoded(object source, EventArgs args){
		Console.WriteLine("MessageService: sending an message....");
	}
}

class Program{
	static void Main(string [] args){
		var video = new Video() {Title = "Video 1"};
		var videoEncoder = new VideoEncoder();
		var mailService = new MailService();
		var messageService = new MessageService();

		videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
		videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
		videoEncoder.Encode(video);
	}
}