---
title: "EndCapture"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 06084c3b-e065-49b6-968e-d578762fb871
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EndCapture
Ends a capture interval that was started with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A capture interval typically spans a subset of one frame, such as when you want to capture graphics information only about a certain kind of draw call. If the capture interval spans a call to present, then two frames of graphics information are captured. The first frame spans the interval between the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the call to present; the second frame spans the interval between the first Direct3D event after the call to present and the call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 To capture an interval, you must prepare your app to capture and record graphics information—that is, you must have called [Init](../vs140/init.md) through an instance of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class before you call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [BeginCapture](../vs140/begincapture.md)   
 [CaptureCurrentFrame](../vs140/capturecurrentframe.md)