---
title: "Invoking Scripts"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "StringRegister"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StringRegister method"
  - "scripts, invoking registry in ATL"
ms.assetid: eabd41ee-586b-4266-9e92-5aaad04b73a4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Invoking Scripts
[Using Replaceable Parameters (The Registrar's Preprocessor)](../vs140/using-replaceable-parameters--the-registrar-s-preprocessor-.md) discusses replacement maps and mentions the Registrar method **AddReplacement**. The Registrar has eight other methods specific to scripting, and all are described in the following table.  
  
|Method|Syntax/Description|  
|------------|-------------------------|  
|**ResourceRegister**|**HRESULT ResourceRegister( LPCOLESTR**  *resFileName* **, UINT**  <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> **, LPCOLESTR**  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> **);**\<br />\<br /> Registers the script contained in a module's resource. *resFileName* indicates the UNC path to the module itself. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> contain the resource's ID and type, respectively.|  
|**ResourceUnregister**|**HRESULT ResourceUnregister( LPCOLESTR**  *resFileName* **, UINT**  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> **, LPCOLESTR**  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **);**\<br />\<br /> Unregisters the script contained in a module's resource. *resFileName* indicates the UNC path to the module itself. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> contain the resource's ID and type, respectively.|  
|**ResourceRegisterSz**|**HRESULT ResourceRegisterSz( LPCOLESTR**  *resFileName* **, LPCOLESTR**  *szID* **, LPCOLESTR**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **);**\<br />\<br /> Registers the script contained in a module's resource. *resFileName* indicates the UNC path to the module itself. *szID* and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> contain the resource's string identifier and type, respectively.|  
|**ResourceUnregisterSz**|**HRESULT ResourceUnregisterSz( LPCOLESTR**  *resFileName* **, LPCOLESTR**  *szID* **, LPCOLESTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **);**\<br />\<br /> Unregisters the script contained in a module's resource. *resFileName* indicates the UNC path to the module itself. *szID* and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> contain the resource's string identifier and type, respectively.|  
|**FileRegister**|**HRESULT FileRegister( LPCOLESTR**  *fileName*  **);**\<br />\<br /> Registers the script in a file. *fileName* is a UNC path to a file that contains (or is) a resource script.|  
|**FileUnregister**|**HRESULT FileUnregister( LPCOLESTR**  *fileName*  **);**\<br />\<br /> Unregisters the script in a file. *fileName* is a UNC path to a file that contains (or is) a resource script.|  
|**StringRegister**|**HRESULT StringRegister( LPCOLESTR**  *data*  **);**\<br />\<br /> Registers the script in a string. *data* contains the script itself.|  
|**StringUnregister**|**HRESULT StringUnregister( LPCOLESTR**  *data*  **);**\<br />\<br /> Unregisters the script in a string. *data* contains the script itself.|  
  
 **ResourceRegisterSz** and **ResourceUnregisterSz**, are similar to **ResourceRegister** and **ResourceUnregister**, but allow you to specify a string identifier.  
  
 The methods **FileRegister** and **FileUnregister** are useful if you do not want the script in a resource or if you want the script in its own file. The methods **StringRegister** and **StringUnregister** allow the .rgs file to be stored in a dynamically allocated string.  
  
## See Also  
 [Creating Registrar Scripts](../vs140/creating-registrar-scripts.md)