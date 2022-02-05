using Mutagen.Bethesda.Synthesis.Settings;

namespace FacegenBaseline
{
    public class Settings
    {
        [SynthesisSettingName("Baseline Mod")]
        [SynthesisTooltip("This is the plugin holding your baseline facegen, e.g. 'Modpocalypse NPCs (v4) SSE.esp'.")]
        [SynthesisDescription("Facegen settings to be used if no other mod overrides NPC's appearance.")]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public string BaselineMod { get; set; } = "Modpocalypse NPCs (v4) SSE.esp";
    }
}
