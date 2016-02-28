namespace Textamina.Markdig.Syntax.Inlines
{
    public class HardlineBreakInline : LeafInline
    {
        public override string ToString()
        {
            return "<br />";
        }
    }

    public class SoftlineBreakInline : LeafInline
    {
        public override string ToString()
        {
            return "\\n";
        }
    }

}