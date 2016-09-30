---
title: "BeginCapture"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9edbb52d-ee0b-4cc4-a382-972bcee067d3
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BeginCapture
Begins a capture interval that will end with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A capture interval typically spans a subset of one frame, such as when you want to capture graphics information only about a certain kind of draw call. If the capture interval spans a call to present, then two frames of graphics information are captured. The first frame spans the interval between the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the call to present; the second frame spans the interval between the first Direct3D event after the call to present and the call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 To capture an interval, you must prepare your app to capture and record graphics information—that is, you must have called [Init](../vs140/init.md) through an instance of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class before you call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [EndCapture](../vs140/endcapture.md)   
 [CaptureCurrentFrame](../vs140/capturecurrentframe.md)