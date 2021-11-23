"use strict"
function myCreateFunction() {
    
 let a= document.querySelector("a");

document.write(a.getAttribute("href"))
document.write("<br>");
document.write(a.getAttribute("id"))
document.write("<br>");
document.write(a.getAttribute("type"))
document.write("<br>");
document.write(a.getAttribute("rel"))
document.write("<br>");
document.write(a.getAttribute("target"))



  }
//  document.getElementById("but").addEventListener("click",myCreateFunction);
  let task=document.querySelector("button");
  task.addEventListener("click",myCreateFunction);

  