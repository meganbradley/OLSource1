---
title: "CSettingsStore::CSettingsStore"
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
  - "CSettingsStore.CSettingsStore"
  - "CSettingsStore"
  - "CSettingsStore::CSettingsStore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSettingsStore class, constructor"
ms.assetid: 33f904e4-1e85-47f2-b689-8db693e0332e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::CSettingsStore
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Boolean parameter that specifies whether the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is acting in administrator mode.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Boolean parameter that specifies whether the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is created in read-only mode.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member variable is set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If you set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The security access depends on the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the security access will be set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the security access will be set to a combination of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information about security access together with the registry, see [Registry Key Security and Access Rights](http://msdn.microsoft.com/library/windows/desktop/ms724878).  
  
 The destructor for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> releases <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> automatically.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)