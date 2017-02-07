package domain

type Workflow struct {
	ID    int
	Name  string
	Steps map[int]Step
}

type Step struct {
	ID     int
	Value  string
	Action string
}

func (wf *Workflow) AddStep(step Step) {
	wf.Steps[step.ID] = step
}

func (wf *Workflow) DelStep(step Step) {

}
