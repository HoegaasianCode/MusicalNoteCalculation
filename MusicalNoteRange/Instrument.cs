namespace MusicalNoteRange
{
    public class Instrument
    {
        public readonly string _name;
        public readonly short[] _octalRange;
        public readonly char[] _noteRange;
        public readonly short LowestOctave;
        public readonly short HighestOctave;
        public readonly char HighestNote;
        public readonly char LowestNote;

        public Instrument(string name, short[] octalRange, char[] noteRange)
        {
            _name = name;
            _octalRange = octalRange;
            _noteRange = noteRange;
            LowestOctave = _octalRange[0];
            HighestOctave = _octalRange[1];
            LowestNote = _noteRange[0];
            HighestNote = _noteRange[1];
        }
    }
}
