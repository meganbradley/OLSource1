---
title: "Effects of Buffering"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "buffers, effects of buffering"
  - "buffering, effects of"
ms.assetid: 5d544812-e95e-4f28-b15a-edef3f3414fd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Effects of Buffering
The following example shows the effects of buffering. You might expect the program to print <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, wait 5 seconds, and then proceed. It will not necessarily work this way, however, because the output is buffered.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To make the program work logically, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object must empty itself when the message is to appear. To flush an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, send it the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> manipulator:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This step flushes the buffer, ensuring the message prints before the wait. You can also use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> manipulator, which flushes the buffer and outputs a carriage return–linefeed, or you can use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. This object (with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects) is usually tied to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. Thus, any use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (or of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects) flushes the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
## See Also  
 [Output Streams](../vs140/output-streams.md)