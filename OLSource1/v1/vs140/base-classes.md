---
title: "Base Classes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - inheritance, multiple
  - base classes, virtual
  - derived classes, multiple bases
  - multiple inheritance, base classes
  - virtual base classes
  - base classes
ms.assetid: 6e6d54d0-6f21-4a16-9103-22935d98f596
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Base Classes
The inheritance process creates a new derived class that is made up of the members of the base class(es) plus any new members added by the derived class. In a multiple-inheritance, it is possible to construct an inheritance graph where the same base class is part of more than one of the derived classes. The following figure shows such a graph.  
  
 ![Multiple instances of a base class](../vs140/media/vc38xn1.gif "vc38XN1")  
Multiple Instances of a Single Base Class  
  
 In the figure, pictorial representations of the components of `CollectibleString` and `CollectibleSortable` are shown. However, the base class, `Collectible`, is in `CollectibleSortableString` through the `CollectibleString` path and the `CollectibleSortable` path. To eliminate this redundancy, such classes can be declared as virtual base classes when they are inherited.  
  
 For information about declaring virtual base classes and how objects with virtual base classes are composed, see [Virtual Base Classes](../vs140/virtual-base-classes.md).  
  
## See Also  
 [Overview of Derived Classes](../vs140/overview-of-derived-classes.md)