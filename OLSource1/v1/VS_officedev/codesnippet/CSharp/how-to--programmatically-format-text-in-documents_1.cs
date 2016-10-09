        private void RangeFormat() 
        { 
            // Set the Range to the first paragraph. 
            Word.Range rng = this.Paragraphs[1].Range;

            // Change the formatting. To change the font size for a right-to-left language, 
            // such as Arabic or Hebrew, use the Font.SizeBi property instead of Font.Size.
            rng.Font.Size = 14; 
            rng.Font.Name = "Arial"; 
            rng.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            rng.Select(); 
            MessageBox.Show("Formatted Range"); 

            // Undo the three previous actions. 
            object numTimes3 = 3; 
            this.Undo(ref numTimes3); 

            rng.Select(); 
            MessageBox.Show("Undo 3 actions"); 

            // Apply the Normal Indent style. 
            object indentStyle = "Normal Indent"; 
            rng.set_Style(ref indentStyle); 

            rng.Select(); 
            MessageBox.Show("Normal Indent style applied"); 

            // Undo a single action. 
            object numTimes1 = 1; 
            this.Undo(ref numTimes1); 

            rng.Select(); 
            MessageBox.Show("Undo 1 action"); 
        }