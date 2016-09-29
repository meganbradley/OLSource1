---
title: "-baseaddress"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/baseaddress"
f1_keywords: 
  - "/baseaddress"
  - "baseaddress"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-baseaddress compiler option [Visual Basic]"
  - "/baseaddress compiler option [Visual Basic]"
  - "baseaddress compiler option [Visual Basic]"
ms.assetid: c982bcf2-46e5-47a2-bc8f-a5cc32b7dc47
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -baseaddress
Specifies a default base address when creating a DLL.  
  
## Syntax  
  
```  
/baseaddress:address  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`address`|Required. The base address for the DLL. This address must be specified as a hexadecimal number.|  
  
## Remarks  
 The default base address for a DLL is set by the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)].  
  
 Be aware that the lower-order word in this address is rounded. For example, if you specify 0x11110001, it is rounded to 0x11110000.  
  
 To complete the signing process for a DLL, use the `–R` option of the Strong Naming tool (Sn.exe).  
  
 This option is ignored if the target is not a DLL.  
  
||  
|-|  
|To set /baseaddress in the Visual Studio IDE|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).<br />2.  Click the **Compile** tab.<br />3.  Click **Advanced**.<br />4.  Modify the value in the **DLL base address:** box. **Note:**      The **DLL base address:** box is read-only unless the target is a DLL.|  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_csharp/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../VS_csharp/-target--visual-basic-.md)   
 [Sample Compilation Command Lines](../VS_csharp/sample-compilation-command-lines--visual-basic-.md)   
 [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6)