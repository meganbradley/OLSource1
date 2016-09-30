---
title: "DBG_ATTRIB_FLAGS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DBG_ATTRIB_FLAGS"
helpviewer_keywords: 
  - "DBGPROP_ATTRIB_FLAGS enumerations"
ms.assetid: 2f13e601-dadc-476e-a8ec-01c4515082e7
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DBG_ATTRIB_FLAGS
Describes various attributes for an [IDebugProperty2](../vs140/idebugproperty2.md) or an [IDebugReference2](../vs140/idebugreference2.md) interface. Member of the [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DBG_ATTRIB_NONE  
 Indicates no attributes.  
  
 DBG_ATTRIB_ALL  
 Indicates all attributes.  
  
 DBG_ATTRIB_OBJ_IS_EXPANDABLE  
 Indicates that the reference or property has children.  
  
 DBG_ATTRIB_OBJ_HAS_ID  
 Indicates that an ID for this object has been created.  
  
 DBG_ATTRIB_OBJ_CAN_HAVE_ID  
 Indicates that an ID for this object can be created.  
  
 DBG_ATTRIB_VALUE_READONLY  
 Indicates that the value is read-only.  
  
 DBG_ATTRIB_VALUE_ERROR  
 Indicates that the value is an error.  
  
 DBG_ATTRIB_VALUE_SIDE_EFFECT  
 Indicates that the evaluation had a side effect.  
  
 DBG_ATTRIB_OVERLOADED_CONTAINER  
 Indicates that this property is really a container of overloads.  
  
 DBG_ATTRIB_VALUE_BOOLEAN  
 Indicates that the value in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is Boolean.  
  
 DBG_ATTRIB_VALUE_BOOLEAN_TRUE  
 Indicates that the value in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is Boolean and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 DBG_ATTRIB_VALUE_INVALID  
 Indicates that the value in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not valid.  
  
 DBG_ATTRIB_VALUE_NAT  
 Indicates that the value in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is "*not a thing*" (NAT). NAT describes a register flag in Intel 64-bit processors that indicates deferred speculative exceptions.  
  
 DBG_ATTRIB_VALUE_AUTOEXPANDED  
 Indicates that the value in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> has possibly been auto-expanded.  
  
 DBG_ATTRIB_VALUE_TIMEOUT  
 Indicates that an evaluation has timed-out.  
  
 DBG_ATTRIB_VALUE_RAW_STRING  
 Indicates that the value in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be represented by a raw string.  
  
 DBG_ATTRIB_VALUE_CUSTOM_VIEWER  
 Indicates that this property has at least one custom viewer associated with it.  
  
 DBG_ATTRIB_ACCESS_NONE  
 Indicates an object that has neither <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, nor <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type access.  
  
 DBG_ATTRIB_ACCESS_PUBLIC  
 Indicates an object that has public access.  
  
 DBG_ATTRIB_ACCESS_PRIVATE  
 Indicates an object that has private access.  
  
 DBG_ATTRIB_ACCESS_PROTECTED  
 Indicates an object that has protected access.  
  
 DBG_ATTRIB_ACCESS_FINAL  
 Indicates an object that has final access.  
  
 DBG_ATTRIB_ACCESS_ALL  
 Mask to extract the access attributes from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 DBG_ATTRIB_STORAGE_NONE  
 Indicates that there is no storage type specified.  
  
 DBG_ATTRIB_STORAGE_GLOBAL  
 Indicates global storage.  
  
 DBG_ATTRIB_STORAGE_STATIC  
 Indicates static storage.  
  
 DBG_ATTRIB_STORAGE_REGISTER  
 Indicates storage in the register.  
  
 DBG_ATTRIB_STORAGE_ALL  
 Mask to extract the storage attributes from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 DBG_ATTRIB_TYPE_NONE  
 Indicates that there is no type modifier.  
  
 DBG_ATTRIB_TYPE_VIRTUAL  
 Indicates that the type of object is virtual.  
  
 DBG_ATTRIB_TYPE_CONSTANT  
 Indicates that the type of object is constant.  
  
 DBG_ATTRIB_TYPE_SYNCHRONIZED  
 Indicates that the type of object is synchronized.  
  
 DBG_ATTRIB_TYPE_VOLATILE  
 Indicates that the type of object is volatile.  
  
 DBG_ATTRIB_TYPE_ALL  
 Mask to extract the type attributes from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 DBG_ATTRIB_DATA  
 Indicates that this object is a data field.  
  
 DBG_ATTRIB_METHOD  
 Indicates that this object is a method.  
  
 DBG_ATTRIB_PROPERTY  
 Indicates that this object is a property.  
  
 DBG_ATTRIB_CLASS  
 Indicates that this object is a class.  
  
 DBG_ATTRIB_BASECLASS  
 Indicates that this object is a base class.  
  
 DBG_ATTRIB_INTERFACE  
 Indicates that this object is an interface.  
  
 DBG_ATTRIB_INNERCLASS  
 Indicates that this object is an inner class.  
  
 DBG_ATTRIB_MOSTDERIVED  
 Indicates that this object is ‘*most-derived*’. The term "*most-derived*" means the actual type of the object, and not the type of its reference.  
  
 DBG_ATTRIB_CHILD_ALL  
 Indicates a mask of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 DBG_ATTRIB_MULTI_CUSTOM_VIEWERS  
 Indicates that the object has multiple custom viewers associated with it.  
  
## Remarks  
  
> [!NOTE]
>  The values in this enumeration are not actually defined in the assembly for C#. Instead, you must copy the definitions to your source file.  
  
 These flags are also used to filter children of an object, for example, when passed as an argument to [EnumChildren](../vs140/idebugproperty2--enumchildren.md). The values may be combined with a bitwise <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> flag is an indication to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to obtain the [IDebugProperty3](../vs140/idebugproperty3.md) interface from the [IDebugProperty2](../vs140/idebugproperty2.md) interface and call [IDebugProperty3::GetCustomViewerList](../vs140/idebugproperty3--getcustomviewerlist.md) for a list of custom viewers.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugProperty3](../vs140/idebugproperty3.md)   
 [IDebugReference2](../vs140/idebugreference2.md)   
 [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md)