---
title: "Playing Sounds (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "system sounds, playing"
  - "system sounds"
  - "playing sounds, Visual Basic"
  - "sound loops"
  - "My.Computer.Audio object, tasks"
  - "sounds, playing"
  - "sounds, background"
  - "playing sounds"
ms.assetid: f0d9e4ab-57c7-47b6-86d3-99ff07078040
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Playing Sounds (Visual Basic)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object provides methods for playing sounds.  
  
## Playing Sounds  
 Background playing lets the application execute other code while the sound plays. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method allows the application to play only one background sound at a time; when the application plays a new background sound, it stops playing the previous background sound. You can also play a sound and wait for it to complete.  
  
 In the following example, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method plays a sound. When <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is specified, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> waits until the sound completes before calling code continues. When using this example, you should ensure that the file name refers to a .wav sound file that is on your computer  
  
 [!code[VbVbalrMyComputer#15](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_1.vb)]  
  
 In the following example, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method plays a sound. When using this example, you should ensure that the application resources include a .wav sound file that is named Waterfall.  
  
 [!code[VbVbalrMyComputer#16](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_2.vb)]  
  
## Playing Looping Sounds  
 In the following example, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method plays the specified sound in the background when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is specified. When using this example, you should ensure that the file name refers to a .wav sound file that is on your computer.  
  
 [!code[VbVbalrMyComputer#11](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_3.vb)]  
  
 In the following example, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method plays the specified sound in the background when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is specified. When using this example, you should ensure that the application resources include a .wav sound file that is named Waterfall.  
  
 [!code[VbVbalrMyComputer#12](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_4.vb)]  
  
 The preceding code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Windows Forms Applications > Sound**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
 In general, when an application plays a looping sound, it should eventually stop the sound.  
  
## Stopping the Playing of Sounds in the Background  
 Use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method to stop the application's currently playing background or looping sound.  
  
 In general, when an application plays a looping sound, it should stop the sound at some point.  
  
 The following example stops a sound that is playing in the background.  
  
 [!code[VbVbalrMyComputer#18](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_5.vb)]  
  
 The preceding code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Windows Forms Applications > Sound**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## Playing System Sounds  
 Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method to play the specified system sound.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method takes as a parameter one of the shared members from the \<xref:System.Media.SystemSound*> class. The system sound \<xref:System.Media.SystemSounds.Asterisk*> generally denotes errors.  
  
 The following example uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method to play a system sound.  
  
 [!code[VbVbalrMyComputer#17](../vs140/codesnippet/VisualBasic/playing-sounds--visual-basic-_6.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Devices.Audio*>   
 \<xref:Microsoft.VisualBasic.Devices.Audio.Play*>   
 \<xref:Microsoft.VisualBasic.Devices.Audio.PlaySystemSound*>   
 \<xref:Microsoft.VisualBasic.Devices.Audio.Stop*>   
 \<xref:Microsoft.VisualBasic.AudioPlayMode*>