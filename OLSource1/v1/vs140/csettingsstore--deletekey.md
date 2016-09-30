---
title: "CSettingsStore::DeleteKey"
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
  - "CSettingsStore::DeleteKey"
  - "DeleteKey"
  - "CSettingsStore.DeleteKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteKey method"
ms.assetid: 085e4cc6-b2ae-4a78-abde-55e161adc2e0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::DeleteKey
Deletes a key and all its children from the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the key to delete.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Switch that specifies the location of the key to delete.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This method will fail if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is in read-only mode.  
  
 If the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> searches for the key to delete under <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is nonzero, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> searches for the key to delete under <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)