using Raylib_cs;
using ImGuiNET;
using StoryCreator;

namespace GUI
{ 
    public class GUI
    { 
        public static void Main()
        {
            Raylib.InitWindow(1280, 720, "Story Creator");
            Raylib.SetTargetFPS(60);

            var context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);

            var controller = new ImGuiController();

            while (!Raylib.WindowShouldClose())
            {
                controller.NewFrame();
                controller.ProcessEvent();
                ImGui.NewFrame();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKGRAY);

                if (ImGui.Button("Click me!"))
                {
                    Console.WriteLine("button clicked.");
		        }

                ImGui.Render();
                controller.Render(ImGui.GetDrawData());
                Raylib.EndDrawing();
	        }
            controller.Shutdown();
        }
    }
}