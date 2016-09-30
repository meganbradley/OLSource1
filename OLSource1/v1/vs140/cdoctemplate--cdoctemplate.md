---
title: "CDocTemplate::CDocTemplate"
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
  - "CDocTemplate.CDocTemplate"
  - "CDocTemplate::CDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocTemplate class, constructor"
  - "templates, constructing"
ms.assetid: 5694de82-c90f-4ca2-83f1-d892c2a6e8dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::CDocTemplate
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the ID of the resources used with the document type. This may include menu, icon, accelerator table, and string resources.  
  
 The string resource consists of up to seven substrings separated by the '\n' character (the '\n' character is needed as a place holder if a substring is not included; however, trailing '\n' characters are not necessary); these substrings describe the document type. For information on the substrings, see [GetDocString](../vs140/cdoctemplate--getdocstring.md). This string resource is found in the application's resource file. For example:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 Note that the string begins with a '\n' character; this is because the first substring is not used for MDI applications and so is not included. You can edit this string using the string editor; the entire string appears as a single entry in the String Editor, not as seven separate entries.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object of the document class. This class is a **CDocument**-derived class you define to represent your documents.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object of the frame window class. This class can be a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived class, or it can be <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> itself if you want default behavior for your main frame window.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object of the view class. This class is a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived class you define to display your documents.  
  
## Remarks  
 Use this member function to construct a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. Dynamically allocate a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object and pass it to [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md) from the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function of your application class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)   
 [CMultiDocTemplate::CMultiDocTemplate](../vs140/cmultidoctemplate--cmultidoctemplate.md)   
 [CSingleDocTemplate::CSingleDocTemplate](../vs140/csingledoctemplate--csingledoctemplate.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)