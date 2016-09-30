---
title: "Unable to read the resource information from the licx file"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.fail_reading_licx_file"
ms.assetid: e59f0965-fa1c-4852-bd39-63430d5b7d9f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unable to read the resource information from the licx file
The .licx file could not be read by the project system. As part of preparing licenses, the project system will transform text .licx files into binary resources files that are suitable for use with the COM+ licensing model.  
  
 The .licx file is automatically generated or updated by the Windows Forms Designer whenever a licensed control is added to the form. There is one .licx file per project; it is always in the root folder and is always named Licenses.licx.  
  
 Some reasons for this error:  
  
-   Permission denied.  
  
-   Lost communication with the Web server for Web projects.  
  
 The build process will fail if this error occurs.  
  
## See Also  
 [Licensing Components and Controls](assetId:///8e66c1ed-a445-4b26-8185-990b6e2bbd57)