---
title: "CSettingsStore::Read"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CSettingsStore.Read"
  - "CSettingsStore::Read"
  - "Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Read method"
ms.assetid: 19d589be-228c-434c-a848-be5a2572a53f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::Read
Reads a value from a key in the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the name of the value to read from the registry.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to an integer variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reference to a string variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Reference to a string list variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Reference to a string array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Reference to a 16-bit word array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Reference to a byte array variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Reference to a [CRect](../vs140/crect-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to a pointer to data that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Pointer to an unsigned integer variable. This variable receives the size of the buffer that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> points to.  
  
 [out] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Reference to a [CObList](../vs140/coblist-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Reference to a [CObject](../vs140/cobject-class.md) variable that receives the value read from the registry key.  
  
 [out] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variable that receives the value read from the registry key.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> checks for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> as a subkey of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)