---
title: "CSettingsStore::Write"
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
  - "CSettingsStore::Write"
  - "Write"
  - "CSettingsStore.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Write method"
ms.assetid: b0493fc2-3e17-4832-bf9b-a3fa7072d46a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::Write
Writes a value to the registry under the open key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a string that contains the name of the value to set.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to an integer variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Reference to a [CStringList](../vs140/cstringlist-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Reference to a byte array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Reference to a string array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Reference to a 32-bit double word array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Reference to a 16-bit word array variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Reference to a [CRect](../vs140/crect-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Reference to a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Pointer to a buffer that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the data to which the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter points.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Reference to a [CObList](../vs140/coblist-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Reference to a [CObject](../vs140/cobject-class.md) variable that contains the data to store.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Pointer to a pointer to a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> variable that contains the data to store.  
  
## Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
 In order to write to the registry, you must set <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to a nonzero value when you create a [CSettingsStore](../vs140/csettingsstore-class.md) object. For more information, see [CSettingsStore::CSettingsStore](../vs140/csettingsstore--csettingsstore.md).  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CSettingsStore::CSettingsStore](../vs140/csettingsstore--csettingsstore.md)