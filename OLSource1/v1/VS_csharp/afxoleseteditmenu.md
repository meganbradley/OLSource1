---
title: "AfxOleSetEditMenu"
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
  - "AfxOleSetEditMenu"
  - "AFXOLE/AfxOleSetEditMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleSetEditMenu function"
  - "application control"
ms.assetid: d749d675-6817-4916-9db0-03c8895f551d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleSetEditMenu
Implements the user interface for the *typename* Object command.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxOleSetEditMenu(  
   COleClientItem* pClient,  
   CMenu* pMenu,  
   UINT iMenuItem,  
   UINT nIDVerbMin,  
   UINT nIDVerbMax = 0,  
   UINT nIDConvert = 0   
);  
```  
  
#### Parameters  
 `pClient`  
 A pointer to the client OLE item.  
  
 `pMenu`  
 A pointer to the menu object to be updated.  
  
 *iMenuItem*  
 The index of the menu item to be updated.  
  
 `nIDVerbMin`  
 The command ID that corresponds to the primary verb.  
  
 *nIDVerbMax*  
 The command ID that corresponds to the last verb.  
  
 *nIDConvert*  
 ID for the Convert menu item.  
  
## Remarks  
 If the server recognizes only a primary verb, the menu item becomes "verb *typename* Object" and the `nIDVerbMin` command is sent when the user chooses the command. If the server recognizes several verbs, then the menu item becomes "*typename* Object" and a submenu listing all the verbs appears when the user chooses the command. When the user chooses a verb from the submenu, `nIDVerbMin` is sent if the first verb is chosen, `nIDVerbMin` + 1 is sent if the second verb is chosen, and so forth. The default `COleDocument` implementation automatically handles this feature.  
  
 You must have the following statement in your client's application resource script (.RC) file:  
  
 **#include <afxolecl.rc>**  
  
## Requirements  
 **Header**: afxole.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [COleDocument Class](../VS_csharp/coledocument-class.md)