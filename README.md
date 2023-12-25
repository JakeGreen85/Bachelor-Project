# Background
Research project centered around motivation in VR fitness applications.

The goal of the project is to shed light on the question: "What intrinsic motivational factor is most important?"

### Intrinsic motivational factors
- Autonomy
  - Feeling of control
- Competence
  - User ability
  - "How competent is the user?"
- Relatedness
  - Feeling part of a community
  - Leaderboard, multiplayer, etc.

### Final project and game idea
The final project will be a VR application dedicated to user testing. It will feature 4 different parts (one for each motivational factor from above), while the last will give the user the ability to choose to replay one of the 3.

The game will be based off of Beat Saber but for boxing ([Supernatual](https://www.getsupernatural.com/?gad_source=1&gclid=CjwKCAiAvoqsBhB9EiwA9XTWGWVEeRLK9L_vp2Ft8HprtH0cyfJ3X68DLpVEyN3WWjsqPos07pAdexoCqCcQAvD_BwE) & [FitXR](https://fitxr.com/))

# Developer Log
The developer log is a chronological list of implementation steps, to give an overview of the implementation process.

<details>
 
<summary>December 20, 2023</summary>

I worked on the abstract for the research paper, the game design of each version of the game, and implemented the initial game mechanics of the game.
## Abstract
### What is the background of the project/idea
Intrinsic motivation is crucial

Intrinsic motiviation has 3 components:
- Autonomy
- Competence
- Relatedness

All 3 components are good to have (GDT), but not always feasible to implement. Therefore, the goal of the project is to shed light on the question: "Which factor is most important?" or "Which factor has highest effect on users?".

### What is the motivation for the project/idea
The main issue with fitness VR applications is retaining users over time. Furhtermore, it is known that all 3 motivational factors are important, but they are not always feasible to implement in all games. Therefore, it is valuable to know how each component affect users' motivation when it comes to fitness VR applications.

### What is the concrete idea/project
The final project will be a VR application dedicated to user testing. It will feature 4 different parts (one for each motivational factor from above), while the last will give the user the ability to choose to replay one of the 3.

The game will be based off of Beat Saber but for boxing ([Supernatual](https://www.getsupernatural.com/?gad_source=1&gclid=CjwKCAiAvoqsBhB9EiwA9XTWGWVEeRLK9L_vp2Ft8HprtH0cyfJ3X68DLpVEyN3WWjsqPos07pAdexoCqCcQAvD_BwE) & [FitXR](https://fitxr.com/))

### What is the method you use
I will implement a fitness application that will put the user in different versions of a game, that each focus on their own factor of motivation. Once pilot testing is done, the user study will begin, where users will come and go through a somewhat guided use of the application, before answering a questionnaire about intrinsic motivation.

### What are the results of the project
Hopefully the results of the project is that one factor has a higher effect on motivation on users.

### What are the implications of the project
The results can help others to implement applications with higher motivational success.

## Game Design
| Autonomy | Competence | Relatedness |
| -------- | ---------- | ----------- |
| Different gloves | Progress bar | Other players in the world |
| Different landscape | Increase difficulty over time | Leaderboard (Live & Overall) |
| Different projectiles | Forgiveness mechanic | Trainer |
| Different songs | Grading system |  |
|  | Constructive feedback |  |

## Initial game mecahnics
Projectiles coming towards you to the beat of a song ([Ride it - Regard](https://www.youtube.com/watch?v=LoSm6VkplJc))

Start & Stop buttons

Shelves for wearable objects (only hats so far)
 
</details>
<details>

<summary>December 24, 2023</summary>

***Changed the SDK used from "OpenXR" to "Meta All-in-One"***

I kept working on game functionality, as well as found some papers on the topic, to see what previous research has concluded about the subject.

## Game Functionality
- Added dodge, hook, and uppercut projectiles.
- Added choice of the use of hand tracking or controllers
- Scoreboard (Highscore, score, streak, and highest streak) + point system
- Created a gameplay recording for the current state of the application:
    - [Recording](Recordings/24-12-23.mp4)

## Similar Research
Some papers that relate to physical activity and the 3 components of intrinsic motivation (autonomy, competence, and relatedness). These were just a few of the ones I found:
- ***The Role of Relatedness in Physical Activity Motivation, Behaviour, and Affective Experiences: A Self-Determination Theory Perspective*** - Mcdonough, Meghan Heather
- ***The Role of Perceived Competence in the Motivation of Physical Activity*** - Williams, Lavon & Gill, Diane L.
  - Understanding the role of perceived competence in the motivation of sport and physical activity is an important endeavor. This study attempted to examine the role of perceived competence by (a) investigating its relationship with goal orientations as hypothesized by Nicholls's theory of achievement motivation, and (b) testing a proposed model linking goal orientations and motivated behavior. Students (N = 174) completed questionnaires assessing goal orientations, perceived competence, intrinsic interest, and effort. Regression analyses revealed that task orientation was a good predictor of effort; however, the interaction of ego orientation and perceived competence failed to adequately predict effort. Path analysis results revealed that task goal orientation, but not ego orientation, directly influenced perceived competence, intrinsic interest, and effort. In addition, intrinsic interest played a mediating role between perceived competence and effort and between task goal orientation and effort.
- ***The Effects of Choice on Autonomous Motivation, Perceived Autonomy Support, and Physical Activity Levels in High School Physical Education*** - Yew Meng, How & Whipp, Peter & Dimmock, James & Jackson, Ben
  - This study examined whether the provision of choice in physical education (PE) enhanced students’ autonomous motivation, perceived autonomy support, and physical activity (PA) levels, relative to a “regular PE” control group. Students from eight intact high school PE classes (N = 257, Mage = 12.91) were randomly assigned to control (i.e., four classes) and intervention (i.e., four classes) conditions. Students in the intervention group were given a unique opportunity to choose their preferred participatory role in their PE units, while control students participated in normal teacher-led PE, and data were collected over a 15-week program (i.e., three units of five weeks each). The results indicated that a lack of choice in PE aligned with less positive perceptions of autonomy support among students within the control group, compared with their counterparts in the intervention group. In some choice formats, students exhibited significantly higher PA levels than students who undertook normal PE. These findings indicate that offering choice in high school PE lessons may encourage perceptions of autonomy support and levels of in-class physical activity.
- ***Dancing in virtual reality as an inclusive platform for social and physical fitness activities: a survey*** - Sarupuri, Bhuvaneswari & Kulpa, Richard & Aristidou, Andreas & Multon, Franck
  - Virtual reality (VR) has recently seen signiﬁcant development in interaction with computers and the visualization of information. More and more people are using virtual and immersive technologies in their daily lives, especially for entertainment, ﬁtness, and socializing purposes. This paper presents a qualitative evaluation of a large sample of users using a VR platform for dancing (N = 292); we study the users’ motivations, experiences, and requirements for using VR as an inclusive platform for dancing, mainly as a social or physical activity. We used an artiﬁcial intelligence platform (OpenAI) to extract categories or clusters of responses automatically. We organized the data into six user motivation categories: fun, ﬁtness, social activity, pandemic, escape from reality, and professional activities. Our results indicate that dancing in virtual reality is a different experience than in the real world, and there is a clear distinction in the user’s motivations for using VR platforms for dancing. Our survey results suggest that VR is a tool that can positively impact physical and mental well-being through dancing. These ﬁndings complement the related work, help in identifying the use cases, and can be used to assist future improvements of VR dance applications.

 I was also able to find a questionnaire that was suitable for my user testing ([IMI](https://selfdeterminationtheory.org/intrinsic-motivation-inventory/)), which I will rewrite to fit my project.
</details>
