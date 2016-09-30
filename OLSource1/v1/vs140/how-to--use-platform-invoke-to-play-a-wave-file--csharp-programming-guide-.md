---
title: "How to: Use Platform Invoke to Play a Wave File (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "platform invoke, sound files"
  - "interoperability [C#], playing WAV files using pinvoke"
  - "wav files"
  - ".wav files"
ms.assetid: f7f62f53-e026-4c40-b221-3a26adb0c2c5
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Platform Invoke to Play a Wave File (C# Programming Guide)
The following C# code example illustrates how to use platform invoke services to play a wave sound file on the Windows operating system.  
  
## Example  
 This example code uses <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to import <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method entry point as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The example has a simple Windows Form with a button. Clicking the button opens a standard windows \<xref:System.Windows.Forms.OpenFileDialog*> dialog box so that you can open a file to play. When a wave file is selected, it is played by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method of the winmm.DLL assembly method. For more information about winmm.dll's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method, see [Using the PlaySound function with Waveform-Audio Files](http://go.microsoft.com/fwlink/?LinkId=148553). Browse and select a file that has a .wav extension, and then click **Open** to play the wave file by using platform invoke. A text box shows the full path of the file selected.  
  
 The **Open Files** dialog box is filtered to show only files that have a .wav extension through the filter settings:  
  
 [!code[csProgGuideInterop#5](../vs140/codesnippet/CSharp/how-to--use-platform-invoke-to-play-a-wave-file--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideInterop#3](../vs140/codesnippet/CSharp/how-to--use-platform-invoke-to-play-a-wave-file--csharp-programming-guide-_2.cs)]  
  
## Compiling the Code  
  
### To compile the code  
  
1.  Create a new C# Windows Application project in Visual Studio and name it **WinSound**.  
  
2.  Copy the code above, and paste it over the contents of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> file.  
  
3.  Copy the following code, and paste it in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> file, in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method, after any existing code.  
  
     [!code[csProgGuideInterop#4](../vs140/codesnippet/CSharp/how-to--use-platform-invoke-to-play-a-wave-file--csharp-programming-guide-_3.cs)]  
  
4.  Compile and run the code.  
  
## .NET Framework Security  
 For more information, see [.NET Framework Security](http://go.microsoft.com/fwlink/?LinkId=37122).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Using Interoperability (C#)](../vs140/interoperability-overview--csharp-programming-guide-.md)   
 [Interoperability Overview (C# Programming Guide)](../vs140/interoperability-overview--csharp-programming-guide-.md)   
 [A Closer Look at Platform Invoke](assetId:///ba9dd55b-2eaa-45cd-8afd-75cb8d64d243)   
 [Marshaling Data with Platform Invoke](assetId:///dc5c76cf-7b12-406f-b79c-d1a023ec245d)