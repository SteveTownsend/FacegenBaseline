using Mutagen.Bethesda.Synthesis.Settings;
using System.Collections.Generic;

namespace FacegenBaseline
{
    public class Settings
    {
        [SynthesisSettingName("Baseline Mod")]
        [SynthesisTooltip("This is the plugin holding your baseline facegen, e.g. 'Modpocalypse NPCs (v4) SSE.esp'.")]
        [SynthesisDescription("Facegen settings to be used if no other mod overrides NPC's appearance.")]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public string BaselineMod { get; set; } = "Modpocalypse NPCs (v4) SSE.esp";

        const string _excludeNPCByKeywordsDescription = "List of string keywords. All npc with editorid including the keywords will be skipped.";
        [SynthesisSettingName("Excluded npc edid keywords list")]
        [SynthesisTooltip(_excludeNPCByKeywordsDescription)]
        [SynthesisDescription(_excludeNPCByKeywordsDescription)]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public List<string> ExcludeNPCByKeywords { get; set; } = new List<string>();
    }
}
