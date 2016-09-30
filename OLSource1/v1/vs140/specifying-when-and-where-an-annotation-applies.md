---
title: "Specifying When and Where an Annotation Applies"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_Group_"
  - "_At_"
  - "_When_"
  - "_At_buffer_"
ms.assetid: 8e4f4f9c-5dfa-4835-87df-ecd1698fc650
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying When and Where an Annotation Applies
When an annotation is conditional, it may require other annotations to specify that to the analyzer.  For example, if a function has a variable that can be either synchronous or asynchronous, the function behaves as follows: In the synchronous case it always eventually succeeds, but in the asynchronous case it reports an error if it can’t succeed immediately. When the function is called synchronously, checking the result value provides no value to the code analyzer because it would not have returned.  However, when the function is called asynchronously and the function result is not checked, a serious error could occur. This example illustrates a situation in which you could use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> annotation—described later in this article—to enable checking.  
  
## Structural Annotations  
 To control when and where annotations apply, use the following structural annotations.  
  
|Annotation|Description|  
|----------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is an expression that yields an lvalue. The annotations in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are applied to the object that is named by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For each annotation in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is interpreted in pre-condition if the annotation is interpreted in pre-condition, and in post-condition if the annotation is interpreted in post-condition.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an expression that yields an lvalue. The annotations in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are applied to the object that is named by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For each annotation in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is interpreted in pre-condition if the annotation is interpreted in precondition, and in post-condition if the annotation is interpreted in post-condition.\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the name of a variable that is scoped to the annotation (inclusive of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> has an implicit type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Identically named variables in any enclosing scope are hidden from evaluation.\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is an expression that evaluates to an integer.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The annotations in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are all considered to have any qualifier that applies to the group annotation that is applied to each annotation.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is an expression that can be converted to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. When it is non-zero (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>), the annotations that are specified in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are considered applicable.\<br />\<br /> By default, for each annotation in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is interpreted as using the input values if the annotation is a precondition, and as using the output values if the annotation is a post-condition. To override the default, you can use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> intrinsic when you evaluate a post-condition to indicate that input values should be used. **Note:**  Different annotations might be enabled as a consequence of using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if a mutable value—for example, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>—is involved because the evaluated result of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in precondition may differ from its evaluated result in post-condition.|  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../vs140/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)