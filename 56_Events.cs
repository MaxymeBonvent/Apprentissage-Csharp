// 56. EVENTS

namespace Lesson56
{
    class Program56
    {
        // public static void Main()
        // {
        //     /*
        //         An event is a notification sent by an object to signal the occurrence of an 
        //         action. Events in .NET follow the observer design pattern.

        //         The class who raises events is called Publisher, and the class who receives 
        //         the notification is called Subscriber. 
        //         There can be multiple subscribers of a single event. 
        //         Typically, a publisher raises an event when some action occurred. 
        //         The subscribers, who are interested in getting a notification when an action 
        //         occurred, should register with an event and handle it.

        //         In C#, an event is an encapsulated delegate. It is dependent on the delegate. 
        //         The delegate defines the signature for the event handler method of the 
        //         subscriber class.

        //         The following figure illustrates the event in C#. 
        //     */

        //     /*
        //         DECLARE AN EVENT

        //         An event can be declared in two steps:

        //         1. Declare a delegate.
        //         2. Declare a variable of the delegate with "event" keyword.

        //         The following example shows how to declare an event in a publisher class.
        //     */

        //     /*
        //         In the above example, we declared a delegate Notify and then declared an 
        //         event ProcessCompleted of delegate type Notify using "event" keyword in the 
        //         ProcessBizLogic class. Thus, the ProcessBizLogic class is called 
        //         the publisher. The Notify delegate specifies the signature for the 
        //         ProcessCompleted event handler. It specifies that the event handler method in 
        //         subscriber class must have a void return type and no parameters.

        //         Now, let's see how to raise the ProcessCompleted event. 
        //         Consider the following implementation.
        //     */

        //     /*
        //         Below, the StartProcess() method calls the method onProcessCompleted() at the 
        //         end, which raises an event. Typically, to raise an event, protected and 
        //         virtual method should be defined with the name On<EventName>. Protected and 
        //         virtual enable derived classes to override the logic for raising the event. 
        //         However, A derived class should always call the On<EventName> method of the 
        //         base class to ensure that registered delegates receive the event.

        //         The OnProcessCompleted() method invokes the delegate using 
        //         ProcessCompleted?.Invoke();. This will call all the event handler methods 
        //         registered with the ProcessCompleted event.

        //         The subscriber class must register to ProcessCompleted event and handle it 
        //         with the method whose signature matches Notify delegate, as shown below.
        //     */

        //     ProcessBizLogic bizLo = new();
        //     // bizLo.ProcessCompleted += ProcessCompleted;
        //     bizLo.StartProcess();

        //     /*
        //         Above, the Program56 class is a subscriber of the ProcessCompleted event.
        //         It registers with the event using += operator. Remember, this is the same 
        //         way we add methods in the invocation list of multicast delegate. 
        //         The ProcessCompleted() method handles the event because it matches the 
        //         signature of the Notify delegate.
        //     */

        //     /*
        //         BUILT-IN EVENTHANDLER DELEGATE

        //         The .NET Framework includes built-in delegate types EventHandler and 
        //         EventHandler<TEventArgs> for the most common events. Typically, any event 
        //         should include two parameters: the source of the event and event data. 
        //         Use the EventHandler delegate for all events that do not include event data. 
        //         Use EventHandler<TEventArgs> delegate for events that include data to be sent 
        //         to handlers.

        //         The example shown above can use EventHandler delegate without declaring a 
        //         custom Notify delegate, as shown below.
        //     */

        //     /*
        //         In the above example, the event handler bl_ProcessCompleted() method includes 
        //         two parameters that match with EventHandler delegate. 
        //         Also, passing this as a sender and EventArgs.Empty, when we raise an event 
        //         using Invoke() in the OnProcessCompleted() method. Because we don't need any 
        //         data for our event, it just notifies subscribers about the completion of the 
        //         process, and so we passed EventArgs.Empty.
        //     */

        //     /*
        //         PASSING AN EVENT DATA

        //         Most events send some data to the subscribers. The EventArgs class is the 
        //         base class for all the event data classes. .NET includes many built-in event 
        //         data classes such as SerialDataReceivedEventArgs. It follows a naming pattern 
        //         of ending all event data classes with EventArgs. You can create your custom 
        //         class for event data by deriving EventArgs class.

        //         Use EventHandler<TEventArgs> to pass data to the handler, as shown below.
        //     */

        //     /*
        //         In the above example, we are passing a single boolean value to the handlers 
        //         that indicate whether the process completed successfully or not.

        //         If you want to pass more than one value as event data, then create a class 
        //         deriving from the EventArgs base class, as shown below.

        //         The following example shows how to pass custom ProcessEventArgs class to the 
        //         handlers.
        //     */

        //     // Thus, you can create, raise, register, and handle events in C#.

        //     /*
        //         Points to Remember :

        //         1. An event is a wrapper around a delegate. It depends on the delegate.

        //         2. Use "event" keyword with delegate type variable to declare an event.

        //         3. Use built-in delegate EventHandler or EventHandler<TEventArgs> for common 
        //         events.

        //         4. The publisher class raises an event, and the subscriber class registers 
        //         for an event and provides the event-handler method.

        //         5. Name the method which raises an event prefixed with "On" with the event 
        //         name.

        //         6. The signature of the handler method must match the delegate signature.

        //         7. Register with an event using the += operator. Unsubscribe it using 
        //         the -= operator. Cannot use the = operator.

        //         8. Pass event data using EventHandler<TEventArgs>.

        //         9. Derive EventArgs base class to create custom event data class.

        //         10. Events can be declared static, virtual, sealed, and abstract.

        //         11. An Interface can include the event as a member.

        //         12. Event handlers are invoked synchronously if there are multiple subscribers.
        //     */
        // }

        class ProcessEventArgs : EventArgs
        {
            public bool IsSuccessful {get; set;}
            public DateTime CompletionTime {get; set;}
        }

        // Event handler
        // public void ProcessCompleted(object sender, ProcessEventArgs e)
        // {
        //     Console.WriteLine("Process " + (e.IsSuccessful? "Completed Successfully": "failed"));
        //     Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        // }

        // Delegate
        public delegate void Notify();

        // Event
        public class ProcessBizLogic
        {
            // declaring an event using built-in EventHandler
            // public event EventHandler<bool>? ProcessCompleted_H2; 

            // // Declaring an event using the built-in EventHandler class
            // public event EventHandler? ProcessCompleted_H;

            // public event Notify? ProcessCompleted;

            // public void StartProcess()
            // {
            //     var data = new ProcessEventArgs();

            //     try
            //     {
            //         Console.WriteLine("Process started.");
                    
            //         data.IsSuccessful = true;
            //         data.CompletionTime = DateTime.Now;
            //         OnProcessCompleted(data);
            //     }

            //     catch(Exception ex)
            //     {
            //         Console.WriteLine($"Exception caught: {ex.Message}");

            //         data.IsSuccessful = false;
            //         data.CompletionTime = DateTime.Now;
            //         OnProcessCompleted(data);
            //     }
            // }
        }

        protected static void OnProcessCompleted(EventArgs e)
        {
            // ProcessCompleted?.Invoke(IsSuccessful);
        }
    }
}