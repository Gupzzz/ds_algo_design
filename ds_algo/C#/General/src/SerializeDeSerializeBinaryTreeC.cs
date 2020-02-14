using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VScode
{
    class SerializeDeSerializeBinaryTreeC
    {
        private const string Empty_Marker = "1";
        public string Serialize(NodeString node)
        {
            if (node == null)
            {
                return Empty_Marker + '-';
            }

            var builder = new StringBuilder();

            builder.Append($"{node.Value}-");

            builder.Append(Serialize(node.left));
            builder.Append(Serialize(node.right));

            return builder.ToString();
        }

        public NodeString Deserialize(string serializedNode)
        {
            var nodes = serializedNode
                .Split('-', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var queue = new Queue<string>(nodes);

            var node = DeserializeNode(queue);

            return node;
        }

        private NodeString DeserializeNode(Queue<string> nodes)
        {
            if (nodes.Peek() != null)
            {
                var nextNode = nodes.Dequeue();

                if (nextNode == Empty_Marker)
                {
                    return null;
                }

                var node = new NodeString(nextNode);

                node.left = DeserializeNode(nodes);

                node.right = DeserializeNode(nodes);

                return node;
            }

            return null;
        }
    }
}