---
title: "DECLARE_OBJECT_DESCRIPTION"
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
  - "DECLARE_OBJECT_DESCRIPTION"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_OBJECT_DESCRIPTION macro"
ms.assetid: 32ac881c-97b1-44e2-a017-0e23eb99ac93
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_OBJECT_DESCRIPTION
Allows you to specify a text description for your class object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 [in] The class object's description.  
  
## Remarks  
 ATL enters this description into the object map through the [OBJECT_ENTRY](assetId:///abd10ee2-54f0-4f94-9ec2-ddf8f4c8c8cd) macro.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> implements a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function, which you can use to override the [CComCoClass::GetObjectDescription](../vs140/ccomcoclass--getobjectdescription.md) method.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function is called by **IComponentRegistrar::GetComponents**. **IComponentRegistrar** is an Automation interface that allows you to register and unregister individual components in a DLL. When you create a Component Registrar object with the ATL Project Wizard, the wizard will automatically implement the **IComponentRegistrar** interface. **IComponentRegistrar** is typically used by Microsoft Transaction Server.  
  
 For more information about the ATL Project Wizard, see the article [Creating an ATL Project](../vs140/creating-an-atl-project.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#123](../vs140/codesnippet/CPP/declare_object_description_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Object Map Macros](../vs140/object-map-macros.md)   
 [Macros](../vs140/atl-macros.md)