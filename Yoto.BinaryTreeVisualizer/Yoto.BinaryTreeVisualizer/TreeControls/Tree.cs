using System;
using System.Collections.Generic;
using System.Text;
using static Yoto.BinaryTreeVisualizer.TreeControls.Node;

namespace Yoto.BinaryTreeVisualizer.TreeControls
{
    public class Tree
    {
        protected List<Node> nodes = new List<Node>();
        public int Count { get; set; }

        public Tree()
        {}

        public void AddNode(Node root, Node newNode)
        {
            Node aux1;
            Node aux2;

            if (isEmpty())
            {
                nodes.Add(newNode);
                root.Right = root.Left = null;
                root.Bal = Balance.Center;
            }
            else if (newNode.Value < root.Value)
            {
                AddNode(root.Left, newNode);
                switch (root.Bal)
                {
                    case Balance.Right:
                        root.Bal = Balance.Center;
                        break;
                    case Balance.Center:
                        root.Bal = Balance.Left;
                        break;
                    case Balance.Left:
                        aux1 = root.Left;
                        if (aux1.Bal == Balance.Left) //rebalanceamento simples
                        {
                            root.Left = aux1.Right;
                            aux1.Right = root;
                            root.Bal = Balance.Center;
                            root = aux1;
                        }
                        else //rebalanceamento duplo
                        {
                            aux2 = aux1.Right;
                            aux1.Right = aux2.Left;
                            aux2.Left = aux1;
                            root.Left = aux2.Right;
                            aux2.Right = root;
                            if (aux2.Bal == Balance.Left)
                            {
                                root.Bal = Balance.Right;
                            }
                            else
                            {
                                root.Bal = Balance.Center;
                            }
                            if (aux2.Bal == Balance.Right)
                            {
                                aux1.Bal = Balance.Left;
                            }
                            else
                            {
                                aux1.Bal = Balance.Center;
                            }
                            root = aux2;
                        }
                        root.Bal = Balance.Center;
                        break;
                }
            }
            else if (newNode.Value > root.Value)
            {
                AddNode(root.Right, newNode);
                if (*h)
                {
                    switch ((*raiz)->bal)
                    {
                        case E:
                            (*raiz)->bal = C;
                            *h = 0;
                            break;
                        case C:
                            (*raiz)->bal = D;
                            break;
                        case D:
                            p1 = (*raiz)->dir;
                            if (p1->bal == D)
                            { // rebalanceamento simples
                                (*raiz)->dir = p1->esq;
                                p1->esq = (*raiz);
                                (*raiz)->bal = C;
                                (*raiz) = p1;
                            }
                            else
                            { //rebalanceamento duplo
                                p2 = p1->esq;
                                p1->esq = p2->dir;
                                p2->dir = p1;
                                (*raiz)->dir = p2->esq;
                                p2->esq = (*raiz);
                                if (p2->bal == D)
                                    (*raiz)->bal = E;
                                else
                                    (*raiz)->bal = C;
                                if (p2->bal == E)
                                    p1->bal = D;
                                else
                                    p1->bal = C;
                                (*raiz) = p2;
                            }
                            (*raiz)->bal = C;
                            *h = 0;
                            break;
                    }
                }
            }
        }

        public bool isEmpty()
        {
            if (Count <= 0) return false;
            else return true;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Node node in nodes)
            {
                stringBuilder.Append(node.ToString()).Append(" ");
            }
            return stringBuilder.ToString();
        }
    }
}
