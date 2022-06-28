using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            List<Actor> segments = snake.GetSegments();
            Actor score = cast.GetFirstActor("score");
            // Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments);
            videoService.DrawActor(score);
            // videoService.DrawActor(food);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }

        public void Execute2(Cast cast, Script script)
        {
            Snake2 snake2 = (Snake2)cast.GetFirstActor2("snake2");
            List<Actor> segments2 = snake2.GetSegments2();
            Actor score = cast.GetFirstActor2("score");
            // Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors2("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments2);
            videoService.DrawActor(score);
            // videoService.DrawActor(food);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}