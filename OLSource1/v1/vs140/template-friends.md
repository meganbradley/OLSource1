---
title: "Template Friends"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 077acea5-0d0f-4b33-916d-1211797e5e28
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template Friends
Class templates can have [friends](assetId:///bf412640-d857-4acb-b2b5-513131cb9681). A class or class template, function, or function template can be a friend to a template class. Friends can also be specializations of a class template or function template, but not partial specializations.  
  
 **C++ 11**:  A type parameter can be declared as a friend by using the form <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> .  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In the following example, a friend function is defined as a function template within the class template. This code produces a version of the friend function for every instantiation of the template. This construct is useful if your friend function depends on the same template parameters as the class does.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **A B C D E F G H I J K L M N O P Q R S T U V W X Y Z**   
**a b c d e f g h i j k l m n o p q r s t u v w x y z**   
**A B C D E F G H I J K L M N O P Q R S T U V W X Y Z a b c d e f g h i j k l m n o p q r s t u v w x y z**    
## Example  
 The next example involves a friend that has a template specialization. A function template specialization is automatically a friend if the original function template is a friend.  
  
 It is also possible to declare only the specialized version of the template as the friend, as the comment before the friend declaration in the following code indicates. If you do this, you must put the definition of the friend template specialization outside of the template class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **10 generic**  
**10 int**   
## Example  
 The next example shows a friend class template declared within a class template. The class template is then used as the template argument for the friend class. Friend class templates must be defined outside of the class template in which they are declared. Any specializations or partial specializations of the friend template are also friends of the original class template.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **65**  
**97**  
**A**  
**a**   
## See Also  
 [Default Arguments](../vs140/default-arguments.md)