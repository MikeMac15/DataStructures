public class MinHeap {
    public int length;
    private List<int> data;

    public MinHeap() {
        this.data = new List<int>();
        this.length = 0;
    }
    private int parent(int idx){
        return (idx - 1) / 2;
    }
    
    private int leftChild(int idx){
        return 2*idx+1;
    }
    private int rightChild(int idx){
        return 2*idx+2;
    }

    private void heapifyUp(int idx){
        if (idx == 0) return;
        int pi = this.parent(idx);
        int pv = this.data[pi];
        int v = this.data[idx];

        if (pv > v){
            this.data[idx] = pv;
            this.data[pi] = v;
            heapifyUp(pi);
        }
    }

    private void heapifyDown(int idx){
        int lIdx = leftChild(idx);
        int rIdx = rightChild(idx);
        if (idx >= this.length || lIdx >= this.length) return;
        int rV = this.data[rIdx];
        int lV = this.data[lIdx];
        int v = this.data[idx];

        if (lV > rV && v > rV){
            this.data[rIdx] = v;
            this.data[idx] = rV;
            heapifyDown(rIdx);
        } else if (rV > lV && v > lV){
            this.data[lIdx] = v;
            this.data[idx] = lV;
            heapifyDown(lIdx);
        }
    }


    public void insert(int value){
        this.data.Add(value);
        this.heapifyUp(this.length);
        this.length++;
    }
    public int delete(){
        if (this.length == 0) return -1;
        int outVal = this.data[0];
        this.length--;
        if (this.length == 0){
            this.data.Clear();
            return outVal;
        }
        this.data[0] = this.data[this.length];
        this.data.RemoveAt(this.length);
        this.heapifyDown(0);
        return outVal;

    }



}