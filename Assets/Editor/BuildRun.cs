using UnityEditor;

public static class BuildRun
{
    [MenuItem("Build/BuildRun")]
    public static void Build()
    {
        //windows64のプラットフォームでアプリをビルドする
        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Level/Scenes/MainGameScene.unity" },
            "Builds/App/Clock.exe",
            BuildTarget.StandaloneWindows64,
            BuildOptions.None
        );
    }
}
