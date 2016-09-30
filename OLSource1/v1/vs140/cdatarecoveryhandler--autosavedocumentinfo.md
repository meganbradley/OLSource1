---
title: "CDataRecoveryHandler::AutosaveDocumentInfo"
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
  - "CDataRecoverHandler::AutosaveDocumentInfo"
  - "AutosaveDocumentInfo"
  - "CDataRecoveryHandler.AutosaveDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutosaveDocumentInfo method"
ms.assetid: a60b3773-f9ee-449f-a3d6-fe09a4ce403a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::AutosaveDocumentInfo
Autosaves the specified document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to save.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> indicates that the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> considers <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be modified; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> indicates that the framework considers <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to be unmodified. See the Remarks section for more information about the effect of this flag.|  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the appropriate flags are set and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a valid <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object has a flag that indicates if it has changed since the last save. Use [CDocument::IsModified](../vs140/cdocument--ismodified.md) to determine the state of this flag. If a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has not changed since the last save, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> deletes any autosaved files for that document. If a document has changed since the last save, closing it prompts the user to save the document before closing.  
  
> [!NOTE]
>  Using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to change the state of the document to unmodified may cause the user to lose unsaved data. If the framework considers a document unmodified, closing it does not prompt the user to save.  
  
 This method throws an exception with the [ASSERT (MFC)](../vs140/assert--mfc-.md) macro if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a valid <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
 To use this method, either <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::AutosaveAllDocumentInfo](../vs140/cdatarecoveryhandler--autosavealldocumentinfo.md)   
 [CDocument Class](../vs140/cdocument-class.md)