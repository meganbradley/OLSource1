---
title: "The selected Add-In has not been confirmed to be &#39;Command Line Safe&#39;, and may require some user intervention (possible UI)."
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
  - "vs.message.0x800A0031"
  - "vs.message.VB_E_IDWADDINCMDLINE"
ms.assetid: 19dd24d4-b0f5-4c92-9005-aad48ffda7d9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# The selected Add-In has not been confirmed to be &#39;Command Line Safe&#39;, and may require some user intervention (possible UI).
This error generally occurs when an Add-in has been selected to be used from the Command prompt (DOS prompt) but the add-in does not list itself as safe for the command line. The add-in might display UI that could interfere with command line use.  
  
### To correct this error  
  
1.  From the **Tools** menu, choose **Add-In Manager**.  
  
2.  In **the Add-In Manager** dialog box, clear **Command Line** for the add-in.  
  
## See Also  
 [How to: Control Add-ins with the Add-in Manager](assetId:///4f60444a-cb48-4cdb-8df4-941f6419aeeb)   
 [Creating an Add-In](assetId:///50be56d2-e3a5-4cd2-8569-2a0666b268ce)