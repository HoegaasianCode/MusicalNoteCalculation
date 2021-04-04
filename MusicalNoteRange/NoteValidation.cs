namespace MusicalNoteRange
{
    public class NoteValidation
    {
        private readonly Instrument[] _instruments;
        private Instrument Instrument;
        private readonly string _instrumentName;
        private readonly string _noteAndOctave;
        private readonly char Note;
        private readonly short Octave;
        private bool IsValid;
        
        public NoteValidation(string instrumentName, string noteAndOctave, params Instrument[] instruments)
        {
            _instrumentName = instrumentName;
            _noteAndOctave = noteAndOctave;
            _instruments = instruments;
            Note = _noteAndOctave[0];
            Octave = (short)_noteAndOctave[1];
            IsValid = true;
        }

        public void LookUpInstrument()
        {
            for(int i = 0; i < _instruments.Length; i++)
            {
                Instrument instrument = _instruments[i];
                if (instrument._name == _instrumentName)
                {
                    Instrument = instrument;
                }
            }
        }

        public void IsValidOctave() // "A3", "C4" -> D4-C7 
        {
            if (Octave < Instrument.LowestOctave || Octave > Instrument.HighestOctave)
            {
                IsValid = false;
            }
        }

        public void IsValidNote() // E3-E6
        {
            if (Note < Instrument.LowestNote || Note > Instrument.HighestNote)
            {
                IsValid = false;
            }
        }

        public bool IsValidNoteAndOctave() => IsValid;
    }
}
