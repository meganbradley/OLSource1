---
title: "Intermediate Materialization (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 7922d38f-5044-41cf-8e17-7173d6553a5e
caps.latest.revision: 7
---
# Intermediate Materialization (C#)
If you are not careful, in some situations you can drastically alter the memory and performance profile of your application by causing premature materialization of collections in your queries. Some standard query operators cause materialization of their source collection before yielding a single element. For example, <xref:System.Linq.Enumerable.OrderBy*?displayProperty=fullName> first iterates through its entire source collection, then sorts all items, and then finally yields the first item. This means that it is expensive to get the first item of an ordered collection; each item thereafter is not expensive. This makes sense: It would be impossible for that query operator to do otherwise.  
  
## Example  
 This example alters the previous example. The `AppendString` method calls <xref:System.Linq.Enumerable.ToList*> before iterating through the source. This causes materialization.  
  
```c#  
public static class LocalExtensions  
{  
    public static IEnumerable<string>  
      ConvertCollectionToUpperCase(this IEnumerable<string> source)  
    {  
        foreach (string str in source)  
        {  
            Console.WriteLine("ToUpper: source >{0}<", str);  
            yield return str.ToUpper();  
        }  
    }  
  
    public static IEnumerable<string>  
      AppendString(this IEnumerable<string> source, string stringToAppend)  
    {  
        // the following statement materializes the source collection in a List<T>  
        // before iterating through it  
        foreach (string str in source.ToList())  
        {  
            Console.WriteLine("AppendString: source >{0}<", str);  
            yield return str + stringToAppend;  
        }  
    }  
}  
  
class Program  
{  
    static void Main(string[] args)  
    {  
        string[] stringArray = { "abc", "def", "ghi" };  
  
        IEnumerable<string> q1 =  
            from s in stringArray.ConvertCollectionToUpperCase()  
            select s;  
  
        IEnumerable<string> q2 =  
            from s in q1.AppendString("!!!")  
            select s;  
  
        foreach (string str in q2)  
        {  
            Console.WriteLine("Main: str >{0}<", str);  
            Console.WriteLine();  
        }  
    }  
}  
```  
  
 This example produces the following output:  
  
```  
ToUpper: source >abc<  
ToUpper: source >def<  
ToUpper: source >ghi<  
AppendString: source >ABC<  
Main: str >ABC!!!<  
  
AppendString: source >DEF<  
Main: str >DEF!!!<  
  
AppendString: source >GHI<  
Main: str >GHI!!!<  
```  
  
 In this example, you can see that the call to <xref:System.Linq.Enumerable.ToList*> causes `AppendString` to enumerate its entire source before yielding the first item. If the source were a large array, this would significantly alter the memory profile of the application.  
  
 Standard query operators can also be chained together. The final topic in this tutorial illustrates this.  
  
-   [Chaining Standard Query Operators Together (C#)](../vs140/chaining-standard-query-operators-together--csharp-.md)  
  
## See Also  
 [Tutorial: Chaining Queries Together (C#)](../vs140/tutorial--chaining-queries-together--csharp-.md)