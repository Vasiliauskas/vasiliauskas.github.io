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
Note: Guess namespace
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
``` cs
// ISubject<T> : ISubject<T,T>, IObservable<T>, IObserver<T> 
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
---
``` cs
Amb(IObservable)
AsyncLast()
Buffer(int i) // overload with timespan for time buffer
CombineLatest(IObservable, combineFunc)
Merge(IObservable)
Switch()
```
---
![Alt text](images/marbles.png)
---
### Testing hard or hardly testing?
``` cs
class TestScheduler // Implements IScheduler
```
---
* UI events
* Domain events
* Streaming services
* Live queries
* Parallel computing
* Mapping and reducing sequences
* Abstracting message queues like RabbitMQ, MS MQ, etc.
---
* http://www.reactivemanifesto.org/
* http://reactivex.io/
* http://www.introtorx.com/
* https://github.com/Reactive-Extensions/
* https://github.com/Vasiliauskas
---
Ačiū :)


