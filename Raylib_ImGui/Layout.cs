using System;
using System.Numerics;
using ImGuiNET;

public static class Layout
{
    public static void Display()
    {
        string hour = string.Format("{0,2:D2}", DateTime.Now.Hour);
        string minute = string.Format("{0,2:D2}", DateTime.Now.Minute);
        string second = string.Format("{0,2:D2}", DateTime.Now.Second);
        ImGui.Text(hour + ":" + minute + ":" + second);

        ImGui.NewLine();

        ImGui.Text(Datas.remain + "/" + Datas.target);


        ImGui.InputInt("Input", ref Datas.target);

        ImGui.Button("Start");
        ImGui.SameLine();
        ImGui.Button("Restart");

        ImGui.Button("<");
        ImGui.SameLine();
        ImGui.Button("=");
        ImGui.SameLine();
        ImGui.Button(">");

        ImGui.NewLine();

        ImGui.Checkbox("BGM", ref Datas.BgmSwitcher);
        ImGui.SameLine();
        ImGui.SliderInt("", ref Datas.BgmVolume, 0, 100);
        ImGui.SameLine();
        ImGui.Checkbox("Mute", ref Datas.BgmMute);
    }
}

public static class Datas
{
    public static int remain = 0;
    public static int target = 10;

    public static bool BgmSwitcher = false;
    public static int BgmVolume = 100;
    public static bool BgmMute = false;
}

