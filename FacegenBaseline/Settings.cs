using Mutagen.Bethesda.Synthesis.Settings;
using System.Collections.Generic;

namespace FacegenBaseline
{
    public class Settings
    {
        [SynthesisSettingName("Baseline Mods list")]
        [SynthesisTooltip("This is the plugins list holding your baseline facegen, like 'Modpocalypse NPCs (v4) SSE.esp'.")]
        [SynthesisDescription("Facegen settings to be used if no other mod overrides NPC's appearance.")]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public List<string> BaselineMods { get; set; } = new List<string>() { "Modpocalypse NPCs (v4) SSE.esp" };

        const string _excludeNPCByKeywordsDescription = "List of string keywords. All npc with editorid including the keywords will be skipped.";
        [SynthesisSettingName("Excluded npc edid keywords list")]
        [SynthesisTooltip(_excludeNPCByKeywordsDescription)]
        [SynthesisDescription(_excludeNPCByKeywordsDescription)]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public List<string> ExcludeNPCByKeywords { get; set; } = new List<string>();

        const string _getProtectedFlagDescription = "Face mod can also mark changed npcs with protected flag. Enable if you need to import it also in patch.";
        [SynthesisSettingName("Get protected flag switcher")]
        [SynthesisTooltip(_getProtectedFlagDescription)]
        [SynthesisDescription(_getProtectedFlagDescription)]
        // public string BaselineMod { get; set; } = "MyFacegenBaseline.esp";
        public bool GetProtectedFlag { get; set; } = true;
    }
}
