---
title: "AfxOleRegisterPropertyPageClass"
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
  - "AFXCTL/AfxOleRegisterPropertyPageClass"
  - "AfxOleRegisterPropertyPageClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleRegisterPropertyPageClass function"
  - "apartment model threading"
ms.assetid: 96a0aeea-4d76-42e7-a5f3-df1bb36cc4e8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleRegisterPropertyPageClass
Registers the property page class with the Windows registration database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The instance handle of the module associated with the property page class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unique class ID of the property page.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The resource ID of the string that contains a user-readable name for the property page.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 May contain the flag:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Sets the threading model in the registry to ThreadingModel = Apartment.  
  
> [!NOTE]
>  In MFC versions prior to MFC 4.2, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter was not available. Note also that the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag is not a valid option for property pages and will cause an ASSERT in MFC if it is set  
  
## Return Value  
 Nonzero if the control class was registered; otherwise 0.  
  
## Remarks  
 This allows the property page to be used by containers that are OLE-control aware. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> updates the registry with the property page name and its location on the system and also sets the threading model that the control supports in the registry. For more information, see [Technical Note 64](../vs140/tn064--apartment-model-threading-in-activex-controls.md), "Apartment-Model Threading in OLE Controls," and [About Processes and Threads](http://msdn.microsoft.com/library/windows/desktop/ms681917) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [AfxOleRegisterControlClass](../vs140/afxoleregistercontrolclass.md)   
 [AfxOleRegisterTypeLib](../vs140/afxoleregistertypelib.md)