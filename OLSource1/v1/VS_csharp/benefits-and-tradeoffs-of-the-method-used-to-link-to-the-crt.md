---
title: "Benefits and Tradeoffs of the Method Used to Link to the CRT"
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
  - "_ATL_MIN_CRT macro"
ms.assetid: 49b485f7-9487-49e4-b12a-0f710b620e2b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Benefits and Tradeoffs of the Method Used to Link to the CRT
Your project can link with the CRT either dynamically or statically. The table below outlines the benefits and tradeoffs involved in choosing which method to use.  
  
|Method|Benefit|Tradeoff|  
|------------|-------------|--------------|  
|Statically linking to the CRT<br /><br /> (**Runtime Library** set to **Single-threaded**)|The CRT DLL is not required on the system where the image will run.|About 25K of startup code is added to your image, substantially increasing its size.|  
|Dynamically linking to the CRT<br /><br /> (**Runtime Library** set to **Multi-threaded**)|Your image does not require the CRT startup code, so it is much smaller.|The CRT DLL must be on the system running the image.|  
  
 The topic [Linking to the CRT in Your ATL Project](../VS_csharp/linking-to-the-crt-in-your-atl-project.md) discusses how to select the manner in which to link to the CRT.  
  
## See Also  
 [Programming with ATL and C Run-Time Code](../VS_csharp/programming-with-atl-and-c-run-time-code.md)   
 [Run-Time Library Behavior](../VS_csharp/run-time-library-behavior.md)   
 [CRT Library Features](../VS_csharp/crt-library-features.md)