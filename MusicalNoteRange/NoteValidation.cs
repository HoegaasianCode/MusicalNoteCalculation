using System;

namespace MusicalNoteRange
{
    public class NoteValidation
    {
        private readonly Instrument[] _instruments;
        private Instrument Instrument;
        private readonly string _instrumentName;
        private readonly string _noteAndOctave;
        private readonly char Note;
        private int Octave;
        public bool IsValid;
        
        public NoteValidation(string instrumentName, string noteAndOctave, params Instrument[] instruments)
        {
            _instrumentName = instrumentName;
            _noteAndOctave = noteAndOctave;
            _instruments = instruments;
            Note = _noteAndOctave[0];
            IsValid = true;
        }

        public void SetOctaveToInt()
        {
            Octave = _noteAndOctave[1] - '0';
        }

        public void LookUpInstrument()
        {
            for(int i = 0; i < _instruments.Length; i++)
            {
                Instrument instrument = _instruments[i];
                if (instrument._name == _instrumentName)
                {
                    Instrument = instrument;
                    break;
                }
            }
        }

        public void IsValidOctalRange()
        {
            if (Octave < Instrument.LowestOctave || Octave > Instrument.HighestOctave)
            {
               IsValid = false;
            }
        }

        public void IsValidLowerNote()
        {
            if (Octave == Instrument.LowestOctave && Note < Instrument.LowestNote)
            {
                IsValid = false;
            }
        }

        public void IsValidHigherNote()
        {
            if (Octave == Instrument.HighestOctave && Note > Instrument.HighestNote)
            {
                IsValid = false;
            }
        }

        public bool IsValidNoteAndOctave() => IsValid;
    }
}
