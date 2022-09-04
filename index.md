---
authors:
  - name: Adam Bacon
    email: adambacon1@hotmail.com
    link: https://twitter.com/psdevuk
    avatar: /imgs/me.jpg
    categories:
  - Powershell
  - Personal
date: 2022-07-16
icon: ":bacon:"
label: About Me
image: /imgs/blog-image.png
description: Personal blog about Powershell
order: 50
---

![Blogs with great comic references](/imgs/blog-image.PNG)

# :icon-person: My Personal Powershell Blog

## A bit about me :neutral_face:

![Great book I have read all my kids](/imgs/life.png)


Well I turned 40 this year :exploding_head: I thought damn that's come about quick :hourglass_flowing_sand:. Just seems the other day I was 26 :man-surfing:. My eldest daughter is 14 this year, and I got 4 daughters :family:. It is just mad how quickly time can fly-past :alarm_clock:. However I remember when I was becoming a dad for the first time :thinking_face: I was trying to better my IT career :pound:. Powershell had just come out as version one, renamed from Monad. I knew a bit about coding DOS, so I thought I would jump in the deep-end :ocean: and learn this new object orientated language Microsoft had just released. So I went and bought :books: books on learning Powershell, and well tried to understand what the heck they were trying to explain :confused: as I got to say at first none of it really made any sense. 

## Why bother with scripting..? :confused:

I remember a long time ago providing 2nd-line support, and I was invited to do some over-time. As I was contracting it was a pretty good hourly rate as it was. Having that at time and a half :money_mouth_face: was really good. So I think about 5 of us turned up for the over-time, and to make the deal even better, the boss bought every-one lots of pizza :pizza: to make up for all the installs we had to do across all the different sites. Anyways by the time we had finished eating this pizza this one particular guy had pretty much finished coding the whole install, to run across all the different sites.
!!!
 I was like no way!
!!!
 He just pressed the enter button on the keyboard, and all the installs kicked off, and ran on each computer at each site. This one guy had just saved the rest of us like 4+ hours of work. I was totally astonished :astonished: that a mere human had just made the computers at each site do the job automatically. This was before Powershell even existed. Pretty much from that day forward I wanted to be that person who could make the computers do the hard work for a change instead of me.
![](/imgs/help.png)

## My first script :receipt:
 At the time I was working for local council providing 2nd-line support to over 700 schools :school: in the south east of England :gb:. My job role did change several times, from being remote support, :computer: to being the main on-site support for 14 different schools, :male-technologist: then moving to supporting various other aspects of the services the council provided. It was during this time they planned a much needed update of Windows XP which was and had been the solution for quite some-time. ```It was taking 4 to 5 consultants one whole week or more``` to visit the school or college who was interested in the upgrade. Then physically and manually check certain aspects of each machine, each monitor, each printer to then collate this information to be able to provide a quote to the school or college on which equipment would need to be replaced, or upgraded to meet the requirements of running Windows 7. 
!!!
One week wage of 4 to 5 people to complete this task
!!!
 I had finished reading my :blue_book: first book, and was feeling that this was a calling from above :wind_blowing_face: to write a script to automate the process of collecting this information, :information_source: and more importantly removing human error :alien: from the equation, as if you have done IT support, you know how tiny those serial numbers are, and trying to tell the difference between a 8 and a B can mean all the difference when you need support from Dell and provide an invalid serial. In my own personal time I had written a long script which would collect all the information they required using WMI, plus some bonus information like knowing how many memory slots were free to be used, doing all this without opening the computer or even needing to visit the school or college. I was able to audit 500+ computers and have all this information in Excel within 45 minutes. Just me one person on my own. :star-struck: Even though I had to jump through lots of burning hoops to get to use my script, and write various emails to explain this no-brainer :brain: process that they would **save money and save time. Lots of it too** :moneybag:
 To me it reminded me that day of eating free pizza :pizza: and getting paid decent money to sit there and well not do a lot. Although it took me a lot longer than the DOS script written years previously, I had felt I had now achieved :level_slider: a new level, and was more than just a point-and-click administrator :three_button_mouse:

## More scripting :recycle:

Thankfully my next job was a lot more challenging than my previous and there was no change management in-place so I had a lot of free regin to choose how to fix a given problem. Previously a lot of my IT jobs were providing IT support for something that was broken or had stopped working. However this job a lot of people seemed to expect you to know how to do their job and write Excel formulas to solve their spreadsheet issues. As well as doing lots of SQL querying for various different departments producing reports, as well as supporting all the IT in the business and 7 remote sites. This was just screaming automation to me, and although I wasn't great at Excel or SQL at the time, it was a great opportunity to become the best I could be. So I was very grateful :grin: when the company I was working for brought me a copy of **Powershell Studio** this then allowed me to make my scripts point and click (yes I know I was trying to get away from that) which in-turn allowed me to develop scripts that would essential automate a particular task or job within the business. I remember how one lady had stacks and stacks of paper on her desk, and was manually holding these up and cross-checking them with the results on the :desktop_computer: screen :t-rex: I was able to get the customer to send the required data via CSV format and automate the whole process for this staff member. I also had managed to solve a critical business issue that had been outstanding for about 5 years that no-one who had previously looked at it had managed to solve, by writing my own SQL stored procedures and running this from a GUI application I built to then display the results. Again this saved the company a massive amount of money, from solving this outstanding problem.
 So the one thing really bugging me at this point was no matter how much I tried, these windows forms I was producing with Powershell Studio always looked like Windows 95 forms to me.
![OldSkool](/imgs/Win95.png)
 So after looking about on the internet for something to help me improve the GUI aspect of my application, and find something better to do reporting in powershell with ```other than having to rely on Excel all the time to compile the finished result```, even if I gathered the data all via Powershell and exported to CSV, it was still Excel as the end thing being displayed with the data. I wanted this to all be :thinking_face: Powershell. Then Universal Dashboard **aka** Powershell Universal had just been released by the very talented Adam Driscoll. Again this was like a calling from above, and I needed to get on this new hype-train :bullettrain_front: right away. Then began a whole new experience with :two_hearts: Powershell and :heart_eyes: React. Universal Dashboard was the best thing since :bread: sliced bread. It was just so amazing :exploding_head: what you could do, like the only thing holding you back was your imagination. For me this really did take my Powershell to another new level, I started to release module after module, and create a blog site dedicated to this amazing software for a good few years.
![https://psdevuk.github.io/ud-flix/](/imgs/udflix.png)
[!ref My UDFLIX Blog Site :point_right:](https://psdevuk.github.io/ud-flix/)

## 100+ Powershell Modules :medal:

 I was very active on the forum for Universal Dashboard, and had seen it change and grow in-size of community members. This software was going to a whole new level, and it did, it became Powershell Universal. As mentioned I was very active in the forum, and being the kind :heartpulse: hearted person I am I tried to make as many of these new web page components I could for other community members to bring some new way of displaying data or navigating the web-pages you could produce. Before I knew it, I had published over 100 modules to the Powershell gallery.

## Recent Modules :crystal_ball:

 Not that long ago on **twitter** where I feel privlidged to have so many :sunglasses: cool connections in the Powershell :earth_americas: world I replied to a tweet about how come Powershell didn't have the equivalent of a hidden gem of a tool from Microsoft aka Logparser. I had some IIS log files I wanted to gather information from and instead of using Powershell I had to rely on an unknown gem from Microsoft, using the command line. Another tweet was posted something along the lines of
||| :point_down: :face_with_rolling_eyes:
Just find a C# library that does the heavy lifting and turn that into a module
|||
 So I was super :smiley: happy when I came back to check on twitter to find a very talented person had only gone and smashed it in about an hour!
[!ref IISParser Module :rocket:](https://evotec.xyz/powershell-modules/iisparser-powershell-module/)
 First I was totally amazed at the fact someone had done this, but secondly they had used a method I did not have knowledge on, making this into a binary module. I was thinking damn :anguished: I have read so many :book: books on Powershell and purchased a good amount of training videos :vhs: but had not come across this :mage: Powershell magic before. Again the very talented Adam Driscoll had recently published the **Sysinternals** module for Powershell and had hosted the template on git which uses Crescendo. He also was kind enough to share a link to a youtube video on the process of making binary modules in Powershell that he uses.
[!embed](https://www.youtube.com/watch?v=4fgccFI-EHY)
 Again I felt this was a calling and the time to try and up my Powershell skill to yet another level and find time to learn this process and produce some new modules, as it had been a while since I had posted anything to the Powershell gallery. So I got busy in the evenings and cooked up some new modules, one of them being the Retype module I used to produce this website.
![Recent Powershell Modules](imgs/Recent.png)





