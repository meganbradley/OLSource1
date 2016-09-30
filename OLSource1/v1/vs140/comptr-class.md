---
title: "ComPtr Class"
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
  - "client/Microsoft::WRL::ComPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComPtr class"
ms.assetid: a6551902-6819-478a-8df7-b6f312ab1fb0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr Class
Creates a *smart pointer* type that represents the interface specified by the template parameter. ComPtr automatically maintains a reference count for the underlying interface pointer and releases the interface when the reference count goes to zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The interface that the ComPtr represents.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A class to which the current ComPtr is a friend. (The template that uses this parameter is protected.)  
  
## Remarks  
 ComPtr<> declares a type that represents the underlying interface pointer. Use ComPtr<> to declare a variable and then use the arrow member-access operator (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) to access an interface member function.  
  
 For more information about smart pointers, see the "COM Smart Pointers" subsection of the [COM Coding Practices](assetId:///76aca556-b4d6-4e67-a2a3-4439900f0c39)topic in the MSDN Library.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A synonym for the type specified by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template parameter.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtr::ComPtr Constructor](../vs140/comptr--comptr-constructor.md)|Intializes a new instance of the ComPtr class. Overloads provide default, copy, move, and conversion constructors.|  
|[ComPtr::~ComPtr Destructor](../vs140/comptr--~comptr-destructor.md)|Deinitializes an instance of ComPtr.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtr::As Method](../vs140/comptr--as-method.md)|Returns a ComPtr object that represents the interface identified by the specified template parameter.|  
|[ComPtr::AsIID Method](../vs140/comptr--asiid-method.md)|Returns a ComPtr object that represents the interface identified by the specified interface ID.|  
|[ComPtr::AsWeak Method](../vs140/comptr--asweak-method.md)|Retrieves a weak reference to the current object.|  
|[ComPtr::Attach Method](../vs140/comptr--attach-method.md)|Associates this ComPtr with the interface type specified by the current template type parameter.|  
|[ComPtr::CopyTo Method](../vs140/comptr--copyto-method.md)|Copies the current or specified interface associated with this ComPtr to the specified output pointer.|  
|[ComPtr::Detach Method](../vs140/comptr--detach-method.md)|Disassociates this ComPtr from the interface that it represents.|  
|[ComPtr::Get Method](../vs140/comptr--get-method.md)|Retrieves a pointer to the interface that is associated with this ComPtr.|  
|[ComPtr::GetAddressOf Method](../vs140/comptr--getaddressof-method.md)|Retrieves the address of the [ptr_](../vs140/comptr--ptr_-data-member.md) data member, which contains a pointer to the interface represented by this ComPtr.|  
|[ComPtr::ReleaseAndGetAddressOf Method](../vs140/comptr--releaseandgetaddressof-method.md)|Releases the interface associated with this ComPtr and then retrieves the address of the [ptr_](../vs140/comptr--ptr_-data-member.md) data member, which contains a pointer to the interface that was released.|  
|[ComPtr::Reset Method](../vs140/comptr--reset.md)|Releases all references for the pointer to the interface that is associated with this ComPtr.|  
|[ComPtr::Swap Method](../vs140/comptr--swap-method.md)|Exchanges the interface managed by the current ComPtr with the interface managed by the specified ComPtr.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtr::InternalAddRef Method](../vs140/comptr--internaladdref-method.md)|Increments the reference count of the interface associated with this ComPtr.|  
|[ComPtr::InternalRelease Method](../vs140/comptr--internalrelease-method.md)|Performs a COM Release operation on the interface associated with this ComPtr.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtr::operator Microsoft::WRL::Details::BoolType Operator](../vs140/comptr--operator-microsoft--wrl--details--booltype-operator.md)|Indicates whether or not a ComPtr is managing the object lifetime of an interface.|  
|[ComPtr::operator& Operator](../vs140/comptr--operator--operator.md)|Retrieves the address of the current ComPtr.|  
|[ComPtr::operator= Operator](../vs140/comptr--operator=-operator.md)|Assigns a value to the current ComPtr.|  
|[ComPtr::operator-> Operator](../vs140/comptr--operator---operator.md)|Retrieves a pointer to the type specified by the current template parameter.|  
|[ComPtr::operator== Operator](../vs140/comptr--operator==-operator.md)|Indicates whether two ComPtr objects are equal.|  
|[ComPtr::operator!= Operator](../vs140/comptr--operator!=-operator.md)|Indicates whether two ComPtr objects are not equal.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[ComPtr::ptr_ Data Member](../vs140/comptr--ptr_-data-member.md)|Contains a pointer to the interface that is associated with, and managed by this ComPtr.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)