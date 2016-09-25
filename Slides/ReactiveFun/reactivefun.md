***
##Event Driven Architecture with
![Alt text](images/rx.png)

Vidas Vasiliauskas
---
< wikipedia >
####Message-driven architecture is a software architecture pattern for production, detection, consumption and reaction to events
</ wikipedia >
---
Over-reactive?
---
### Techradar 2016
![Alt text](images/techradar.png)
---
![Alt text](images/rxlanguages.png)
---
``` cs
interface IObservable<out T>
{
    Subscribe(IObserver<T>)
}

interface IObserver<in T>
{
	OnNext(T)
	OnError(Exception)
	OnCompleted()
}
```
---
## Rx.net
https://github.com/Reactive-Extensions/Rx.NET
---
``` cs
using System.Reactive;
```
---
``` cs
Subject<T>
```
``` cs
RepeatSubject<T>
```
``` cs
BehaviorSubject<T>
```
``` cs
AsyncSubject<T>
```
---
``` cs
interface ISubject<T> : ISubject<T, T>, IObserver<T>, IObservable<T>
```
---
![Alt text](images/comparison.png)
---
...to sequence
![Alt text](images/toobservable.png)
---
####**Rx** vs **Linq**
###                 136 : 55
(No overloads)
``` cs
typeof(Observable).GetMethods()
	.Select(m => m.Name).Distinct().Count(); // 136
typeof(Enumerable).GetMethods()
	.Select(m => m.Name).Distinct().Count(); // 55
```
---
| Use | Avoid |
| --- | ----- |
| UI events| ----- |
| Domain events| ----- |
| Streaming services | ----- |
| Live queries | ----- |
| Async sequencing | ----- |
---
### Testing hard or hardly testing?
``` cs
class TestScheduler // Implements IScheduler
```
---
* http://reactivex.io/
* https://github.com/Reactive-Extensions/
* http://www.introtorx.com/
---
Ačiū :)


