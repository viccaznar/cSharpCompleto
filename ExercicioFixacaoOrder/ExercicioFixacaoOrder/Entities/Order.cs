using System.Text;
using System.Globalization;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        //Instanciando relação 1 para muitos (*)
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order() { 
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Como padrão, adicionand os Métodos 'Add' and 'Remove'
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        //Método para o cálculo do Total
        public Double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += sum + item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));       
            return sb.ToString();
        }
    }
}
